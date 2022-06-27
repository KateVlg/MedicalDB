using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class ExaminationTypeUpdateManager : IUpdateManager<ExaminationType>
    {
        public SqlParameter[] GetParameters(ExaminationType obj)
        {
            SqlParameter par1 = new SqlParameter("id", obj.Id);
            SqlParameter par2 = new SqlParameter("name", obj.Name);

            return new SqlParameter[] { par1, par2 };

        }

        public string UpdateQuery { get { return Queries.ExaminationTypesUpdate; } }
    }
}
