using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.ObjectModel
{
    public class Contract : IId
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("Должность")]
        public string Position { get; set; }

        [DisplayName("Клиника")]
        public string ClinicName { get; set; }

        [Browsable(false)]
        public Clinic clinic  { get; set; }

        [Browsable(false)]
        public int IdClinic { get; set; }

        [DisplayName("Доктор")]
        public string DoctorName { get; set; }

        [Browsable(false)]
        public Doctor doctor { get; set; }

        [Browsable(false)]
        public int IdDoctor { get; set; }

        public override string ToString()
        {
            return ClinicName + " - " + Position + " - " + DoctorName;
        }

        public override bool Equals(object obj)
        {
            if (!Id.HasValue)
                return base.Equals(obj);
            var obj2 = obj as Contract;
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
