using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.ObjectModel
{
    public class Medicines : IId
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }

        [DisplayName("Стоимость")]
        public double Cost { get; set; }

        [DisplayName("Инструкция к применению")]
        public string InstructionsForUse { get; set; }
    }
}
