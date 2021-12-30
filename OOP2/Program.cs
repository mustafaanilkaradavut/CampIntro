using System;

namespace OOP2 // Object Oriented Programming  --- Nesne Yönelimli Programalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Customer = Anıl Karadavut
            
            RetailCustomer customer1 = new RetailCustomer();
            customer1.Id = 177;
            customer1.CitizenshipNumber = "1283";
            customer1.CustomerName = "Anıl";
            customer1.CustomerSurname = "KARADAVUT";
            customer1.CitizenshipNumber = "123456789987";

            // Customer = Kodlama.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 1038;
            customer2.CustomerNumber = "28730";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "108526";

            
            // CompanyName'e ait verimiz yok. Çünkü şahıs hesabı olarak bilgileri girmemiz lazım.
            // Gerçek - Tüzel iki farklı  nesne vardır. Birbirine benziyor diye birbiri yerine kullanılamazlar. Farklı Müşteri Tipleridir..!
            // SOLID Prensiplerine göre birlikte kullanımları yanlıştır. SOLID'DE Kİ " L ".


            Customer customer3 = new RetailCustomer();    // Bir yerde new görüyorsak, bellekteki referans numarasıdır.
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
