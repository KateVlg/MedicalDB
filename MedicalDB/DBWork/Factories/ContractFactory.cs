using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class ContractFactory : IObjectFactory<Contract>
    {
        public Contract CreateObject(IDataReader reader)
        {
            Contract obj = new Contract();
            obj.Id = reader.GetInt32(reader.GetOrdinal("IdContract"));

            if(!reader.IsDBNull(reader.GetOrdinal("Position")))
            obj.Position = reader.GetString(reader.GetOrdinal("Position"));
            obj.IdClinic = reader.GetInt32(reader.GetOrdinal("IdClinic"));
            obj.IdDoctor = reader.GetInt32(reader.GetOrdinal("IdDoctor"));
            obj.DoctorName = reader.GetString(reader.GetOrdinal("FullName"));
            obj.ClinicName = reader.GetString(reader.GetOrdinal("Name"));

            return obj;
        }
    }
}

