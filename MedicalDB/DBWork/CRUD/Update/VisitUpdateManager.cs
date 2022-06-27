using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class VisitUpdateManager : IUpdateManager<VisitingMedicalFacilit>
    {
        public SqlParameter[] GetParameters(VisitingMedicalFacilit obj)
        {
            SqlParameter par0 = new SqlParameter("id", obj.Id);
            SqlParameter par1 = new SqlParameter("DateAndTime", obj.DateAndTime);
            SqlParameter par2 = new SqlParameter("Summ", obj.Summ);
            SqlParameter par3 = new SqlParameter("idContract", obj.contract.Id);
            SqlParameter par4 = new SqlParameter("idFamilyMember", obj.familyMember.Id);

            return new SqlParameter[] { par0, par1, par2, par3, par4 };

        }
        public string UpdateQuery { get { return Queries.VisitUpdate; } }
    }
}
