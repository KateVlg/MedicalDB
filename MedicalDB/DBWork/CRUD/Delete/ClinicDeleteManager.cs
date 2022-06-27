using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class ClinicDeleteManager : IDeleteManager<Clinic>
    {
        public string DeleteQuery { get { return Queries.ClinicsDelete; } }
    }
}
