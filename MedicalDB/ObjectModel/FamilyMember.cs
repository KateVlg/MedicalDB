using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.ObjectModel
{
    public class FamilyMember : IId
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("ФИО")]
        public string FullName { get; set; }

        [DisplayName("Дата рождения")]
        public DateTime DateOfBirth {get; set;}

        [DisplayName("Существо")]
        public CreatureType CreatureVar { get; set; }

        [Browsable(false)]
        public int IdCreatureType { get; set; }

        public override string ToString()
        {
            return FullName;
        }

        public override bool Equals(object obj)
        {
            if (!Id.HasValue)
                return base.Equals(obj);
            var obj2 = obj as FamilyMember;
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
