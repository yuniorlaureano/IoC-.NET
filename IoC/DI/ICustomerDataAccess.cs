using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.DI
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
