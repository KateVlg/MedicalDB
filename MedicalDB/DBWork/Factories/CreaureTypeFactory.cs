using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class CreaureTypeFactory : IObjectFactory<CreatureType>
    {
        public CreatureType CreateObject(IDataReader reader)
        {
            CreatureType obj = new CreatureType();
            obj.Id = reader.GetInt32(reader.GetOrdinal("IdCreatureType"));
            obj.Name = reader.GetString(reader.GetOrdinal("Name"));

            return obj;
        }
    }
}
