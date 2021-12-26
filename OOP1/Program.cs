using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Değer tip  :  int, double, bool.
            // Referans tip  :  diziler, class, abstract class, interface

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 728;
            product1.ProductName = "Desk";
            product1.UnitPrice = 500;
            product1.UnitInStock = 7;

            // Diğer bir uygulanışı product2'de yaptık aşağıda. Sıralamayı farklı şekilde yazabiliriz.

            Product product2 = new Product { Id = 2, CategoryId = 183, UnitInStock = 13, UnitPrice = 35, ProductName = "Pencil" };

            // PascalCase -- camelCase             // case sensitive = büyük ve küçük harf duyarlılığı.
            ProductManager productManager = new ProductManager();   // sol taraf "Stack" sağ taraf "Heap".
            productManager.Add(product1);


            productManager.Topla2(3, 6);

            int toplamSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamSonucu * 2);


            // Encapsulation = "Product" kategorisinde belirttiğimiz varlıklar ve yukarıdaki belirlediğimiz kümülatif product1-2'lerdir.

            // productManager.Add(product1);
            // Console.WriteLine(product1.ProductName);  Cevabı = Kamera ' dır.


            // int sayi = 100;
            // productManager.BiseyYap(sayi1);
            // Console.WriteLine(sayi);  Cevabı = 100 ' dür.
        }
    }
}
