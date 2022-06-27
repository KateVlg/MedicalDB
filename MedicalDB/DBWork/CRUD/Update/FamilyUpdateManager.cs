using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class FamilyUpdateManager:IUpdateManager<FamilyMember>
    {
        public SqlParameter[] GetParameters(FamilyMember obj)
        {
            SqlParameter par0 = new SqlParameter("id", obj.Id);
            SqlParameter par1 = new SqlParameter("fullName", obj.FullName);
            SqlParameter par2 = new SqlParameter("dateOfBirth", obj.DateOfBirth);
            SqlParameter par3 = new SqlParameter("idCreatureType", obj.CreatureVar.Id);

            return new SqlParameter[] { par0, par1, par2, par3};

        }
        public string UpdateQuery { get { return Queries.FamilyMemberUpdate; } }
    }
}

