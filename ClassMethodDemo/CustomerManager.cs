using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {

        public void List(Customer[] customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name +" "+ item.Surname+" "+item.Age);
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted"+" "+customer.Id +" "+customer.Name+" "+customer.Surname+" "+"Check Your Balance"+" "+customer.Balance);
        }
        public void Add(Customer customer)
        {
            Console.WriteLine("Welcome to Anıl Bank" + " " + customer.Name + " " + customer.Surname + " " + "Current Balance" + " " + customer.Balance);
        }
        public void Campaing(Customer customer)
        {
            Console.WriteLine("Dear Customer, We start to your campaing process" + " " + customer.Id + " " + "Numbered" + " " + customer.Name + " " + customer.Surname);
        }

    }
}
