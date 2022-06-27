using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    class MedicalFieldInsertManager : IInsertManager<MedicalField>
    {
        public string InsertQuery => Queries.MedicalFieldsInsert;

        public MedicalField CreateObject()
        {
            MedicalField obj = new MedicalField();
            obj.Name = "Введите название";

            return obj;
        }

        public SqlParameter[] GetParameters(MedicalField obj)
        {
            SqlParameter par = new SqlParameter("name", obj.Name);

            return new SqlParameter[] { par };
        }
    }
}
