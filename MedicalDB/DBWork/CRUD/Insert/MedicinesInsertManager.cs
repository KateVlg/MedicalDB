using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    class MedicinesInsertManager : IInsertManager<Medicines>
    {
        public string InsertQuery => Queries.MedicinesInsert;

        public Medicines CreateObject()
        {
            Medicines obj = new Medicines();
            obj.Name = "Введите название";


            return obj;
        }

        public SqlParameter[] GetParameters(Medicines obj)
        {
            SqlParameter par = new SqlParameter("name", obj.Name);

            return new SqlParameter[] { par };
        }
    }
}
