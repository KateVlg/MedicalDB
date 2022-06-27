using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class VisitFactory : IObjectFactory<VisitingMedicalFacilit>
    {
        public VisitingMedicalFacilit CreateObject(IDataReader reader)
        {
            VisitingMedicalFacilit obj = new VisitingMedicalFacilit();
            obj.Id = reader.GetInt32(reader.GetOrdinal("IdContract"));
            obj.DateAndTime = reader.GetDateTime(reader.GetOrdinal("DateAndTime"));
            if (!reader.IsDBNull(reader.GetOrdinal("Summ")))
                obj.Summ = reader.GetDouble(reader.GetOrdinal("Summ"));
            obj.IdContract = reader.GetInt32(reader.GetOrdinal("IdContract"));
            obj.IdFamilyMember = reader.GetInt32(reader.GetOrdinal("IdFamilyMember"));

            return obj;
        }
    }
}
