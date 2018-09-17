using System;
using IoC.DI;
using IoC.DIP;
using IoC.IoC;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            //By constructor
            DI.CustomerBusinessLogic byConstructor = new DI.CustomerBusinessLogic(new DI.DataAccess());
            byConstructor.GetCustomerName(12);

            //By method parameter
            DI.CustomerBusinessLogicByMethodParameter byParameter = new DI.CustomerBusinessLogicByMethodParameter();
            byParameter.SetDependency(new DI.DataAccess());
            byParameter.GetCustomerName(22);

        }
    }
}
