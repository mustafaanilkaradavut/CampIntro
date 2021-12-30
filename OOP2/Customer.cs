using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    internal class Customer  // Referans tutucu sınıfımızdır.
    {
        // public int Id { get; set; }
        // public string CustomerNumber { get; set; }
        // public string CustomerName { get; set; }
        // public string CustomerSurname { get; set; }
        // public string CompanyName { get; set; }
        // public string CitizenshipNumber { get; set; }
        // public string TaxNumber { get; set; }   

        // Sayı görevi vermediğimiz ve sayısal işlem yapmadığımız için string olarak kullanırız.
        // Farklı iki nesneyi Gerçek Müşteri - Tüzel Müşteri beraber kullanılamaz.
        // Bir nesnede bir nesneyi kullanma zorunluluğumuz yoksa, nesneye ait değilmiş gibi duruyorsa eğer " Soyutlama Hatası " var.

        public int Id { get; set; }
        public string CustomerNumber { get; set; }

        // Bu iki özellik hem Tüzel'de hem Gerçek kişide olduğu için ortak alanda yer alır.



    }
}
