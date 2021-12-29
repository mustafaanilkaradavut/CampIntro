﻿using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="Anıl", LastName="Karadavut", City="Ankara" };
            Customer customer2 = new Customer ( 2, "Burak", "Çoban", "Çorum" );

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.WriteLine (customer2.FirstName);

        }

   
    }

    class Customer 
    {
        public Customer()
        {

        }
        public Customer(int id,string firstName, string lastName, string city)  // Bu işleme " Constructors " denir. " ctor + tab + tab "
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("New Block Started");   // Bir şey yazılmamış ise " Default Constructor " denir. ( Parametresi olmayan. )
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
