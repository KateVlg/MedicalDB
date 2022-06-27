using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    class AnalysisTypeInsertManager : IInsertManager<AnalysisType>
    {
        public string InsertQuery => Queries.AnalysisTypesInsert;

        public AnalysisType CreateObject()
        {
            AnalysisType obj = new AnalysisType();
            obj.Name = "Введите название";

            return obj;
        }

        public SqlParameter[] GetParameters(AnalysisType obj)
        {
            SqlParameter par = new SqlParameter("name", obj.Name);

            return new SqlParameter[] { par };
        }
    }
}

