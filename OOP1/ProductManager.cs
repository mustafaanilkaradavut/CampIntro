using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class ProductManager
    {
       // public void Add(Product product)
       // {
            // product.ProductName = " Kamera  ";
       // }

        // public.void BiseyYap(int sayi)
        // {
                // sayi = 99;
        // }
        public void Add(Product product) // Void ; 
        {
            Console.WriteLine(product.ProductName + " Added Product.");
        }
        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " Uptade Product.");
        }
        
        public int Topla(int sayi1, int sayi2)  // Program akışında eğer bunun sonucuna ihtiyacımız varsa kullanılırız.
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
