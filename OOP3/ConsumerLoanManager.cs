using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class ConsumerLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer Loan Pay Plans Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
