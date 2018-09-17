using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.DIP
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
