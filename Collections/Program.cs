using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"Anıl","Burak","Eren","Pınar"}; // Bu dizi gerçekte bir veri kaynağından gelir.
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            // Burada dizileri genişletemez ve 5. Elemanı yazamayız.

            // names = new string[5];
            // names[4] = "Elif";
            // Console.WriteLine(names[4]);
            // Console.WriteLine(names[0]);

            // Burada new string diyince yeni bir heap atamış oluruz ve [0] değer / yani üsteki değere ulaşamayız.


            // Genellikle gerçek hayatta çok fazla Array kullanılmaz. Onun yerine koleksiyon kullanılır.

            List<string> names2 = new List<string> { "Anıl","Burak","Eren","Pınar"};
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Elif");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[1]);

            // Arrayler'deki gibi kaybolmaz önceki listemize ve verilerimize ekleme yapmış oluruz.

        }
    }
}
