using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    class CreatureTypeInsertManager : IInsertManager<CreatureType>
    {
        public string InsertQuery => Queries.CreaturesTypesInsert;

        public CreatureType CreateObject()
        {
            CreatureType obj = new CreatureType();
            obj.Name = "Введите название";

            return obj;
        }

        public SqlParameter[] GetParameters(CreatureType obj)
        {
            SqlParameter par = new SqlParameter("name", obj.Name);

            return new SqlParameter[] { par };
        }
    }
}
