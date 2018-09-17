using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.DIP
{
    public class DataAccess : ICustomerDataAccess
    {
        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }
}
