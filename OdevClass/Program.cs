using System;

namespace OdevClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Herhangi bir e-ticaret sistemine giriniz.
            // Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir. Siz de Urun (Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.
            // Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.
            // Kodlarınızın arasına yorum satırı ekleyerek, ilgili satırın ne işe yaradığını anlatabilirsiniz.

            PetShopByCimri urun1 = new PetShopByCimri();
            urun1.UrunAdi = "Kedi Ürünleri";
            urun1.UrunIcerik = "Kedi Mamaları, Kuru Mama, Tuvalet Kumu, Yaş Mama";
            urun1.UrunAdedi = 14438;

            PetShopByCimri urun2 = new PetShopByCimri();
            urun2.UrunAdi = "Köpek Ürünleri";
            urun2.UrunIcerik = "Köpek Mamaları, Köpek Tasması, Diş Çıkarma Oyuncağı";
            urun2.UrunAdedi = 48362;

            PetShopByCimri urun3 = new PetShopByCimri();
            urun3.UrunAdi = "Balık - Akvaryum Ürünleri";
            urun3.UrunIcerik = "Akvaryumlar, Balık Yemleri, Su Temizleyiciler";
            urun3.UrunAdedi = 3098;

            PetShopByCimri urun4 = new PetShopByCimri();
            urun4.UrunAdi = "Kuş Ürünleri";
            urun4.UrunIcerik = "Kuş Kafesi, Kuş Yemi, Kuş Törpüsü, Yem Kapları";
            urun4.UrunAdedi = 1963;

            PetShopByCimri[] product = new PetShopByCimri[] { urun1, urun2, urun3, urun4 };
            foreach (var productItems in product)
                Console.WriteLine(productItems.UrunAdi + " - " + productItems.UrunIcerik + " - " + productItems.UrunAdedi);

            Console.WriteLine(" ");
            Console.WriteLine("FOREACH BİTTİ");
            Console.WriteLine(" ");


            string[] urunBasliklari = new string[] { "Elektronik,Cep Telefonu", "Ev,Yaşam,Ofis,Kırtasiye", "Anne,Bebek,Oyuncak",
            "Saat,Moda,Takı,Ayakkabı", "Kitap,Müzik,Hobi","Spor,Outdoor","Sağlık,Bakım,Kozmetik","Oto,Bahçe,Yapı Market"};

            for (int i = 0; i < urunBasliklari.Length; i++)
            {
                Console.WriteLine(urunBasliklari[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("FOR BİTTİ");
            Console.WriteLine(" ");


            int x = 0;
            while (x < urunBasliklari.Length)
            {
                Console.WriteLine(urunBasliklari[x]);
                x++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("WHİLE BİTTİ");
            Console.WriteLine(" ");

        }
    }
    class PetShopByCimri
    {
        public string UrunAdi { get; set; }
        public string UrunIcerik { get; set; }
        public int UrunAdedi { get; set; }
 
    }
}
