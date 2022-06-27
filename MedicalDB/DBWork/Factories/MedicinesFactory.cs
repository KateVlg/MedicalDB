using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class MedicinesFactory : IObjectFactory<Medicines>
    {
        public Medicines CreateObject(IDataReader reader)
        {
            Medicines obj = new Medicines();
            obj.Id = reader.GetInt32(reader.GetOrdinal("IdMedicines"));
            obj.Name = reader.GetString(reader.GetOrdinal("Name"));
            obj.Cost = reader.GetDouble(reader.GetOrdinal("Cost"));
            obj.InstructionsForUse = reader.GetString(reader.GetOrdinal("InstructionsForUse"));
            return obj;
        }
    }
}
