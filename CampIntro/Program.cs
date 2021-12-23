using System;

namespace CampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu şekilde bir değişiklik yapmak istediğimizde tek tek değil kategoriEtiketi bölümünden değiştirmemiz yeterli.
            // Type Safety - Tip Güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            // Değer Tutucu - Alias

            string KategoriEtiketi = "Kategori";
            Console.WriteLine(KategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = true;  // Gerçek Hayatta True yazısı gerçek bir veri kaynağından gelir.

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
        }
    }
}
