using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class MedicalFieldDeleteManager : IDeleteManager<MedicalField>
    {
        public string DeleteQuery { get { return Queries.MedicalFieldsDelete; } }
    }
}
