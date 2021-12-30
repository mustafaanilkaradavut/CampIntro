using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class MortgageLoanManager : ICreditManager  // Ampule tıklayıp "Implement Interface" deriz.
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Loan Pay Plans Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
