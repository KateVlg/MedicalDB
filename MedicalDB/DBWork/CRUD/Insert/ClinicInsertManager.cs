using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    class ClinicInsertManager : IInsertManager<Clinic>
    {
        public string InsertQuery => Queries.ClinicsInsert;

        public Clinic CreateObject()
        {
            Clinic obj = new Clinic();
            obj.Name = "Введите название";
            obj.Phone = "Введите номер";
            obj.Address = "Введите адрес";

            return obj;
        }

        public SqlParameter[] GetParameters(Clinic obj)
        {
            SqlParameter par1 = new SqlParameter("name", obj.Name);
            SqlParameter par2 = new SqlParameter("phone", obj.Phone);
            SqlParameter par3 = new SqlParameter("address", obj.Address);

            return new SqlParameter[] { par1, par2, par3 };
        }
    }
}