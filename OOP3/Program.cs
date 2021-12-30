using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
            consumerLoanManager.Calculate();

            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            vehicleLoanManager.Calculate();

            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            mortgageLoanManager.Calculate();
            
                        //                  YA DA !!!!!!!!!!!!!!!! 
            
            ICreditManager mortagageLoanManager = new MortgageLoanManager();
            mortgageLoanManager.Calculate();
            // interfaceler onunla bağlı diğer verilerle işlenebilirler.


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(consumerLoanManager);


            List<ICreditManager> credits = new List<ICreditManager>() { mortagageLoanManager, vehicleLoanManager};

            applicationManager.CreditInformation(credits);
        }
    }
}
