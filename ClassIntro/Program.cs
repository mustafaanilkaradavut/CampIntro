using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Anıl";
            int yas = 26;

            //Class'taki değişkenleri tanımlamak ve atamak için yapılanlar bunlardır :
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Anıl Karadavut";
            kurs1.IzlenmeOrani = 666;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Burak Çoban";
            kurs2.IzlenmeOrani = 726;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Elif Öğretmen";
            kurs3.IzlenmeOrani = 1923;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurstema in kurslar)
            {
                Console.WriteLine(kurstema.KursAdi + " : " + kurstema.Egitmen);
            }



        }
    }
    class Kurs  // Obje oluşturmak ve farklı veri bilgilerini tek bir tipte toplamaya yarar. ( prop +TAB + TAB )
    {

        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
