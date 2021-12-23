using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Promramlamaya Başlangıç İçin Temel Kurs"; // Böyle tek tek yazmak mantıklı değil, çok fazla ürün ve seçenek olunca listemeye, yazmaya ve değişiklik sırasında sıkıntıya sebep olur. Örneğin E-ticarette 200 ürün varsa.
            string kurs3 = "Java Kursu";
            string kurs4 = "Pyhton Kursu";
            
            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2); Böyle tek tek yazdırmmız mantıklı değil.

            //Bu tip verileri "Array"lerde tutarız. Bunun işareti string[]'dir.
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs",
                "Java Kursu","Pyhton Kursu","C# Kursu"};

            for (int i = 0; i < kurslar.Length; i++)
                Console.WriteLine(kurslar[i]);


            // for (int i = 1; i <= 10; i++) Birden başlayacağak, i<10 kısmı ise şarttır. i++ kısmı ise sayaçtır. 10<= onuda dahil eder.
            {
                // Console.WriteLine(i); //Döngü 10 ve 10'dan küçükse birer birer(i++) arttır demek. İki iki arttır demek (i+=2)
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar) // Dizi temelli yapıları tek tek dönmeye yarar. Burada kursları dolaş demek. Dizilere uygulanır.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("SAYFA SONU - FOOTER");
        }
    }
}
