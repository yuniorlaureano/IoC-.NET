using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.DI
{
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        //by constructor
        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic(new DataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }

        //by property
        public ICustomerDataAccess DataAccess { get; set; }
        

    }
}
