using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class AnalysisTypeFactory : IObjectFactory<AnalysisType>
    {
        public AnalysisType CreateObject(IDataReader reader)
        {
            AnalysisType obj = new AnalysisType();
            obj.Id = reader.GetInt32(reader.GetOrdinal("IdAnalysisType"));
            obj.Name = reader.GetString(reader.GetOrdinal("Name"));

            return obj;
        }
    }
}
