using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class FamilyMemberInsertManager : IInsertManager<FamilyMember>
    {
        public string InsertQuery => Queries.FamilyMemberInsert;

        public FamilyMember CreateObject()
        {
            FamilyMember obj = new FamilyMember();
            obj.FullName = "Введите ФИО";
            obj.DateOfBirth = DateTime.Now;
            obj.IdCreatureType = 1;

            return obj;
        }

        public SqlParameter[] GetParameters(FamilyMember obj)
        {
            SqlParameter par1 = new SqlParameter("fullName", obj.FullName);
            SqlParameter par2 = new SqlParameter("dateOfBirth", obj.DateOfBirth);
            SqlParameter par3 = new SqlParameter("idCreatureType", obj.IdCreatureType);

            return new SqlParameter[] { par1, par2, par3 };
        }
    }
}
