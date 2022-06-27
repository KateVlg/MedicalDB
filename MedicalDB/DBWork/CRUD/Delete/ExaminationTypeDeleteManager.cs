﻿using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class ExaminationTypeDeleteManager : IDeleteManager<ExaminationType>
    {
        public string DeleteQuery { get { return Queries.ExaminationsTypesDelete; } }
    }
}
