using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.IoC
{
    public class CustomerBusinessLogic
    {
        DataAccess _dataAccess;

        public CustomerBusinessLogic()
        {
            _dataAccess = DataAccessFactory.GetDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}
