using System;

namespace GenericsDictionaryWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> useDictionary = new MyDictionary<int, string>();
            useDictionary.Add(1283, "Anıl");
            useDictionary.Add(1938, "Sevim");
            useDictionary.Add(1923, "Çiğiltepe");
            useDictionary.Add(1881, "Neyzen");

        }
    }
}
