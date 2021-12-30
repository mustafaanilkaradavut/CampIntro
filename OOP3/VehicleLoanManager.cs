using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class VehicleLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Loan Pay Plans Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
