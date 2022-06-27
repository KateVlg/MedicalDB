using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.ObjectModel
{
    public class Doctor:IId
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("ФИО врача")]
        public string FullName { get; set; }

        [DisplayName("Связь с врачом")]
        public string Сommunication { get; set; }

        [DisplayName("Мед область")]
        public MedicalField medicalField { get; set; }

        [Browsable(false)]
        public int IdMedicalField { get; set; }

        public override string ToString()
        {
            return FullName;
        }

        public override bool Equals(object obj)
        {
            if (!Id.HasValue)
                return base.Equals(obj);
            var obj2 = obj as Doctor;
            if (obj2 == null || !obj2.Id.HasValue)
                return base.Equals(obj);

            return Id.Value.Equals(obj2.Id.Value);
        }

        public override int GetHashCode()
        {
            if (!Id.HasValue)
                return base.GetHashCode();

            return Id.Value.GetHashCode();
        }
    }
}