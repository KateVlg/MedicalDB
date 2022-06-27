using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class MedicalFieldFactory : IObjectFactory<MedicalField>
    {
        public MedicalField CreateObject(IDataReader reader)
        {
            MedicalField obj = new MedicalField();
            obj.Id = reader.GetInt32(reader.GetOrdinal("IdMedicalField"));
            obj.Name = reader.GetString(reader.GetOrdinal("Name"));

            return obj;
        }
    }
}
