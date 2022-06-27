using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    class ExaminationTypeInsertManager : IInsertManager<ExaminationType>
    {
        public string InsertQuery => Queries.ExaminationTypesInsert;

        public ExaminationType CreateObject()
        {
            ExaminationType obj = new ExaminationType();
            obj.Name = "Введите название";

            return obj;
        }

        public SqlParameter[] GetParameters(ExaminationType obj)
        {
            SqlParameter par = new SqlParameter("name", obj.Name);

            return new SqlParameter[] { par };
        }
    }
}
