using System;
// Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary)
// Sadece ekleme(Add) metodunu yazınız.
namespace MyDictionaryWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string>useDictionary=new MyDictionary<int,string>();
            useDictionary.Add(1283, "Anıl");
            useDictionary.Add(1938, "Sevim");
            useDictionary.Add(1923, "Çiğiltepe");
            useDictionary.Add(1881, "Neyzen");
        }
    }
}
