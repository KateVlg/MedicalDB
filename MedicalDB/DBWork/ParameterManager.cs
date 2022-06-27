using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class ParameterManager
    {
        public List <SqlParameter> GetParameters(List<(string name, object value)> parameters)
        {
            List<SqlParameter> res = new List<SqlParameter>();

            foreach (var item in parameters)
            {
                SqlParameter par = new SqlParameter(item.name, item.value);
                res.Add(par);
            }

            return res;
            
        }
    }
}
