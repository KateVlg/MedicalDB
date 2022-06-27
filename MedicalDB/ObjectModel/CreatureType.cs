using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.ObjectModel
{
    public class CreatureType:IId
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if(!Id.HasValue)
                return base.Equals(obj);
            var obj2 = obj as CreatureType;
            if(obj2 == null || !obj2.Id.HasValue)
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
