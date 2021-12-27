using System;

namespace GenericIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            MyList<string> names = new MyList<string>();
            names.Add("Neyzen");

            Console.WriteLine(names.Length);

            names.Add("Tevfik");

            Console.WriteLine(names.Length);

            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }




        }
    }
}
