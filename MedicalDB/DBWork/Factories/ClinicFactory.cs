using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class ClinicFactory : IObjectFactory<Clinic>
    {
        public Clinic CreateObject(IDataReader reader)
        {
            Clinic obj = new Clinic();
            obj.Id = reader.GetInt32(reader.GetOrdinal("IdClinic"));
            obj.Name = reader.GetString(reader.GetOrdinal("Name"));
            if(!reader.IsDBNull(reader.GetOrdinal("Phone")))
                obj.Phone = reader.GetString(reader.GetOrdinal("Phone"));
            if (!reader.IsDBNull(reader.GetOrdinal("Address")))
                obj.Address = reader.GetString(reader.GetOrdinal("Address"));

            return obj;
        }
    }
}
