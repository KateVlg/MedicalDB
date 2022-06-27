using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class FamilyMemberFactoryFillProp
    {
        List<CreatureType> creatureTypes = new List<CreatureType>();

        void init(string connectionString)
        {

            DbWorker db = new DbWorker(connectionString);

            creatureTypes = db.GetAllData(Queries.CreaturesTypesSelectAll, new CreaureTypeFactory());
        }

        public FamilyMemberFactoryFillProp (string connectionString)
        {
            init(connectionString);
        }

        public void FillObject(FamilyMember familyMember)
        {
            familyMember.CreatureVar = creatureTypes.FirstOrDefault(x => x.Id == familyMember.IdCreatureType);
        }
    }
}
