using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class FamilyMemberFactory : IObjectFactory<FamilyMember>
    {
        public FamilyMember CreateObject(IDataReader reader)
        {
            FamilyMember obj = new FamilyMember();
            obj.Id = reader.GetInt32(reader.GetOrdinal("IdFamilyMember"));
            obj.FullName = reader.GetString(reader.GetOrdinal("FullName"));
            obj.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
            obj.IdCreatureType = reader.GetInt32(reader.GetOrdinal("IdCreatureType"));

            return obj;
        }
    }
}
