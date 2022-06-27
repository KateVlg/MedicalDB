using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class ExaminationTypeFactory : IObjectFactory<ExaminationType>
    {
        public ExaminationType CreateObject(IDataReader reader)
        {
            ExaminationType obj = new ExaminationType();
            obj.Id = reader.GetInt32(reader.GetOrdinal("IdExaminationType"));
            obj.Name = reader.GetString(reader.GetOrdinal("Name"));

            return obj;
        }
    }
}
