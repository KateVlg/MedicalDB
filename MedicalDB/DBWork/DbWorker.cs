using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class DbWorker
    {

        readonly string _connString;

        public DbWorker(string connString)
        {
            _connString = connString;
        }

        public List<T> GetAllData<T>(string query, IObjectFactory<T> factory)
        {
            List<T> res = new List<T>();
            using (SqlConnection con = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        T obj = factory.CreateObject(reader);
                        res.Add(obj);
                    }
                }
            }

            return res;
        }

        public List<T> GetAllData<T>(string query, IObjectFactory<T> factory, Action<T> fillForeignProperties)
        {
            List<T> res = new List<T>();
            using (SqlConnection con = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        T obj = factory.CreateObject(reader);
                        fillForeignProperties(obj);
                        res.Add(obj);
                    }
                }
            }

            return res;
        }

        public void DeleteObject(string query, IId obj)
        {
            using (SqlConnection con = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.CommandText = query;
                    SqlParameter par = new SqlParameter("id", obj.Id);
                    cmd.Parameters.Add(par);
                    cmd.ExecuteNonQuery();                    
                }
            }
        }

        public void UpdateObject<T>(string query, T obj, IUpdateManager<T> updater)
        {
            using (SqlConnection con = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.CommandText = query;
                    var pars = updater.GetParameters(obj);
                    cmd.Parameters.AddRange(pars);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public T InsertObject<T>(string query, IInsertManager<T> inserter) where T:IId
        {
            using (SqlConnection con = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    T obj=inserter.CreateObject();
                    con.Open();
                    cmd.CommandText = query;
                    var pars = inserter.GetParameters(obj);
                    cmd.Parameters.AddRange(pars);
                    var id = cmd.ExecuteScalar();
                    obj.Id= (int)id;
                    return obj;
                }
            }
        }

        public DataTable GetReport(string query, SqlParameter[] pars)
        {
            using (SqlConnection con = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddRange(pars);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();

                        adapter.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
        }

        public List<string> GetStrings(string query, string columnName)
        {
            List<string> res = new List<string>();
            using (SqlConnection con = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    IDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        res.Add(reader.GetString(reader.GetOrdinal(columnName)));
                    }
                }
            }

            return res;
        }
    }
}
