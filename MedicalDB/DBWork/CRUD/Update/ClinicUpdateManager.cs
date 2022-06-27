using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class ClinicUpdateManager : IUpdateManager<Clinic>
    {
        public SqlParameter[] GetParameters(Clinic obj)
        {
            SqlParameter par1 = new SqlParameter("id", obj.Id);
            SqlParameter par2 = new SqlParameter("name", obj.Name);
            SqlParameter par3 = new SqlParameter("Phone", obj.Phone);
            SqlParameter par4 = new SqlParameter("Address", obj.Address);

            return new SqlParameter[] { par1, par2, par3, par4 };

        }
        public string UpdateQuery { get { return Queries.ClinicsUpdate; } }
    }
}

