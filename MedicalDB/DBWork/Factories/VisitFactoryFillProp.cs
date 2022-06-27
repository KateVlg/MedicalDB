using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class VisitFactoryFillProp
    {
        List<Contract> contracts = new List<Contract>();
        List<FamilyMember> familyMember = new List<FamilyMember>();

        void init(string connectionString)
        {

            DbWorker db = new DbWorker(connectionString);

            contracts = db.GetAllData(Queries.ContractSelect, new ContractFactory());
            familyMember = db.GetAllData(Queries.FamilyMemberSelect, new FamilyMemberFactory(), new FamilyMemberFactoryFillProp(connectionString).FillObject);
        }

        public VisitFactoryFillProp(string connectionString)
        {
            init(connectionString);
        }

        public void FillObject(VisitingMedicalFacilit visit)
        {
            visit.contract = contracts.FirstOrDefault(x => x.Id == visit.IdContract);
            visit.familyMember = familyMember.FirstOrDefault(x => x.Id == visit.IdFamilyMember);
        }
    }
}
