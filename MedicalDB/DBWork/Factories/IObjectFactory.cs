using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    public interface IObjectFactory<T>
    {
        T CreateObject(IDataReader reader);
    }
}
