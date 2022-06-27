using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class CreatureTypeUpdateManager : IUpdateManager<CreatureType>
    {
        public SqlParameter[] GetParameters(CreatureType obj)
        {
            SqlParameter par1 = new SqlParameter("id", obj.Id);
            SqlParameter par2 = new SqlParameter("name", obj.Name);

            return new SqlParameter[] { par1, par2 };

        }

        public string UpdateQuery { get { return Queries.CreaturesTypesUpdate; } }
    }
}
