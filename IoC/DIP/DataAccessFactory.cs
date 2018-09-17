using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.DIP
{
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new DataAccess();
        }
    }
}
