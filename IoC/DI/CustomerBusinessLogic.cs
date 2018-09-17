using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.DI
{
    public class CustomerBusinessLogic : ICustomerDataAccess
    {
        ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogic(ICustomerDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}
