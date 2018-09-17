using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.DI
{
    public interface IDataAccessDependency
    {
        void SetDependency(ICustomerDataAccess customerDataAccess);
    }
}
