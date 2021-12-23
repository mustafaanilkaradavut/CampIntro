using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Huawei";
            product1.Price = 10.499;
            product1.Information = "Matebook D-16";
            product1.UnitCapacity = 0;


            Product product2 = new Product();
            product2.Name = "Monster";
            product2.Price = 15.999;
            product2.Information = "Tulpar Gaming Laptop";
            product2.UnitCapacity = 12;

            Product product3 = new Product();
            product3.Name = "Asus";
            product3.Price = 13.899;
            product3.Information = "Zenbook";
            product3.UnitCapacity = 3;


            Product[] products = new Product[] { product1, product2, product3 };

            // Type-safe, tip güveliğidir.
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Information);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("*****------Methods-----*****");

            // instance - Örnek
            // encapsulation -- producte tanımlanıktan sonra burada hata vermez hiç bir şekilde.

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            Console.WriteLine("*****   Add    &    Add2   *****");

            productManager.Add2("Huawei", "Matebook D-16", 10.500, 0);
            productManager.Add2("Monster", "Tulpar Gaming Laptop", 15.999, 10);
            productManager.Add2("Asus", "Zenbook", 13.899, 3);
        }
    }
}
