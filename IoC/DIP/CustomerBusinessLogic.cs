using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.DIP
{
    public class CustomerBusinessLogic : ICustomerDataAccess
    {
        ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogic()
        {
            _dataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}
