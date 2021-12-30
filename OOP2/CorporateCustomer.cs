using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    internal class CorporateCustomer:Customer  // Bu olaya "miras" yani " Inheritance " diyoruz. Müşteri tanımlaması yapıyoruz.
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
