﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.ObjectModel
{
    public class MedicalField : IId
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }
    }
}
