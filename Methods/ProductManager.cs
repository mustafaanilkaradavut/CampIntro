using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    internal class ProductManager
    {
        // Naming Convention, yazım / isimlendirme kuralı.
        // Syntax, yazım şekilleri

        public void Add(Product product)
        {
            // Console.WriteLine("Added Shopping Basket");
            // Biz Ekle yazdığımızda, parantez içi olduğu gibi işler.

            // Mesela bir değişiklik yapmak istedik;
            Console.WriteLine("HEY ! Added Shopping Basket : " + product.Name + " - " + product.Information);
        }

        public void Add2(string productName, string information, double price, int unitCapacity)
        // Burada unitCapacity sonradan eklenince program.cs de sorun yaşarız ve gidip değiştirmemiz lazım hepsinde tek tek. 
        {
            Console.WriteLine("HEY ! Added Shopping Basket : " + productName + " - " + unitCapacity + " - " + information);
        }
    }
}
