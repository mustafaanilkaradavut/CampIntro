using System;

namespace ReferenceTypes
{
    internal class Program
    {
        public static Customer customer { get; private set; }

        static void Main(string[] args)
        {
            // int, decimal, float, enum, boolean değer tiplerdir. " Value Types "
            // STACK'te işlem görür ve orada tanımlanır.
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;

            // Console.WriteLine("Sayi1 : " + sayi1);


            // arrays, class, interface referans tiplerdir. " Reference Types "
            // Referans tiplerde direk adres eşitlemesi yapılır. Aynı adreste yapılan atamalardan etkilenirler.
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 10000;

            // Console.WriteLine("Sayilar1[0] = " + sayilar1[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Anıl";

            person2 = person1;
            person1.FirstName = "Timuçin";

            // Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            Employee employee = new Employee();

            customer.FirstName = "Barbaros";
            customer.CreditCardNumber = "123456789";

            employee.FirstName = "Burak";
            Person person3 = customer;            
            
            // Console.WriteLine(person3.FirstName);

            // Console.WriteLine(((Customer)person3).CreditCardNumber);   // Bu işleme " Boxing " denir.

            PersonalManager personalManager = new PersonalManager();
            personalManager.Add(employee);

            // Burada PersonalManager'da Person person atamamıza rağmen base class'ımız diğer referans klaslarda tanımlı olduğundan
            // employee ve customer içinde uygulayabiliyoruz.
        }
    }

    // Base Class = Person   ----   Temel Class demektir. Temel Class'a onu refere eden classların adreslerini atayabiliriz.
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonalManager
    {
        public void Add(Person person) 
        { 
            Console.WriteLine(person.FirstName);
        }
    }
}
