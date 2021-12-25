using System;

namespace ClassMethodDemo
{

    internal class Program
    {
        // Bir bankada müşteri takibi yapmak istiyorsunuz.
        // Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
        // MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.


        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1283;
            customer1.Name = "Samet";
            customer1.Surname = "Bozkurt";
            customer1.Age = 47;
            customer1.Balance = 957.457;

            Customer customer2 = new Customer();
            customer2.Id = 1938;
            customer2.Name = "Gözde İrem";
            customer2.Surname = "Demirci";
            customer2.Age = 23;
            customer2.Balance = 355.210;

            Customer customer3 = new Customer();
            customer3.Id = 1923;
            customer3.Name = "Pelin";
            customer3.Surname = "Şenay";
            customer3.Age = 34;
            customer3.Balance = 0.00;

            Customer customer4 = new Customer();
            customer4.Id = 1919;
            customer4.Name = "İzel İrem";
            customer4.Surname = "Aydın";
            customer4.Age = 67;
            customer4.Balance = 692.303;

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4};
           
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("Customer List");
            Console.WriteLine("           ");
            customerManager.List(customers);
            Console.WriteLine("                     ");

            customerManager.Add(customer4);
            customerManager.Delete(customer1);
            customerManager.Campaing(customer2);

        }
    }
}
