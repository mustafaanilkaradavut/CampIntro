using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sayısal veri tipleri = Değer Tip = int,decimol,floot,double,bool.
            // Referans Tip = array,class,interface.
            // Bellekte stack ve heap adında iki bölüm vardır. Değer tip stack'te gerçekleşir. Referans tip stack ve heap'te gerçekleşir.
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // Burda sayi1 sayi2'nin değerini alır.
            sayi2 = 65; // Burda sayi2'nin aldığı değerin önemi yok. sayi1 ile bir ilişkisi yoktur.
            //sayi 1 ?? Cevap : 30

            int[] sayilar1 = new int[] { 10, 20, 30 }; // referans numarası aynı oln sayilar 1'in aynı referans numarasın sahip sayıları.
            int[] sayilar2 = new int[] { 100, 200, 300 }; // new demek heap'te bir veri oluştur demek.
            sayilar1 = sayilar2; // burada referans numaraları aynıdır diyoruz.
            sayilar2[0] = 999; // referans numarası değişen sayilar1'in ilk elemanı sayilar2'nin elamanı ile aynıdır.
            //sayilar1[0] ?? Cevap : 999

            // Referans Tip'te adrese atama yapılır.
            // Değer Tip'te değere atama yapılır.
        }
    }
}
