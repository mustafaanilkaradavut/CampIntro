using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class WorkerLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Worker Loan Pay Plans Calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
