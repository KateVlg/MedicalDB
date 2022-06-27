using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.ObjectModel
{
    public class VisitingMedicalFacilit:IId
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("Дата посещения")]
        public DateTime DateAndTime { get; set; }

        [DisplayName("Прием")]
        public Contract contract { get; set; }

        [Browsable(false)]
        public int IdContract { get; set; }

        [DisplayName("Член семьи")]
        public FamilyMember familyMember { get; set; }

        [Browsable(false)]
        public int IdFamilyMember { get; set; }

        [DisplayName("Сумма")]
        public double Summ { get; set; }
    }
}
