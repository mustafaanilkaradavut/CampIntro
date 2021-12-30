using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void Apply(ICreditManager creditmanager) // Hepsinin referansını tuttuğu için interface'sini yazarız.
        {
            // Başvuran bilgilerini değerlendir.

            // MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            // mortgageLoanManager.Calculate(); 
            // !!! Bu işlemde tüm başvurular MortgageLoan'a bağlı hale gelir. !!!! O yüzden yukarıdaki gibi interface bağlarız.

            creditmanager.Calculate();
        }
        public void CreditInformation(List<ICreditManager> credits)  // Birden fazla işlem ve bilgilendirme için.
        {
            foreach (var credit in credits)    // Listede bir sürü eleman olduğundan her birini dönmesi için yaparız.
            {
                credit.Calculate();
            }
        }
    }
}
