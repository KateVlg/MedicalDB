using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class VisitInsertManager : IInsertManager<VisitingMedicalFacilit>
    {
        public string InsertQuery => Queries.VisitInsert;

        public VisitingMedicalFacilit CreateObject()
        {
            VisitingMedicalFacilit obj = new VisitingMedicalFacilit();
            obj.DateAndTime = DateTime.Now;
            obj.IdContract = 1;
            obj.IdFamilyMember = 1;

            return obj;
        }

        public SqlParameter[] GetParameters(VisitingMedicalFacilit obj)
        {
            SqlParameter par1 = new SqlParameter("DateAndTime", obj.DateAndTime);
            SqlParameter par2 = new SqlParameter("IdContract", obj.IdContract);
            SqlParameter par3 = new SqlParameter("IdFamilyMember", obj.IdFamilyMember);

            return new SqlParameter[] { par1, par2, par3 };
        }
    }
}
