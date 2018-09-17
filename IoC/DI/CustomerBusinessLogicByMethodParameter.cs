using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.DI
{
    public class CustomerBusinessLogicByMethodParameter : IDataAccessDependency
    {
        ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogicByMethodParameter()
        {

        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }

        public void SetDependency(ICustomerDataAccess customerDataAccess)
        {
            _dataAccess = customerDataAccess;
        }
    }
}
