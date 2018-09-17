using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.IoC
{
    public class DataAccessFactory
    {
        public static DataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }
}
