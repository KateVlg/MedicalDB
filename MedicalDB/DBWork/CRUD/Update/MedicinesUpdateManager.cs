using MedicalDB.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public class MedicinesUpdateManager : IUpdateManager<Medicines>
    {
        public SqlParameter[] GetParameters(Medicines obj)
        {
            SqlParameter par1 = new SqlParameter("id", obj.Id);
            SqlParameter par2 = new SqlParameter("name", obj.Name);
            SqlParameter par3 = new SqlParameter("Cost", obj.Cost);
            SqlParameter par4 = new SqlParameter("InstructionsForUse", obj.InstructionsForUse);

            return new SqlParameter[] { par1, par2, par3, par4 };

        }

        public string UpdateQuery { get { return Queries.MedicinesUpdate; } }
    }
}
