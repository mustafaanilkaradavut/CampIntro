using System;
using System.Linq;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();   // Aşağıda Add klasörünü değiştirmemiz bizim buradaki tüm işlemlerimiz için geçerlidir.


            // var result = Add2(20,30);
            // var result = Add2(20); Eğer number 2'ye default değer atanmış ve iki sayı varsa.
            // var result =Add2(4); 3 Adet değerimiz varsa ve ilki hariç diğerleri default değerlere sahipse.
            // Console.WriteLine(result);

            // int number1 = 50;
            // int number2 = 100;
            // var result2 = Add3(number1, number2);
            // Console.WriteLine(result2);
            // Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4,10));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6)); // Params Keyword
 
        }

        static void Add()
        {
            Console.WriteLine("Added !");
        }

        // Void : Git şunu yap demek. Verilere bir şeyler yapması için emir veriyoruz.
        // Bu arada number=30 ifadesi defaulttur. Yani number 2 verilmezse 30 atar.
        // Ayrıca number1'e değer atayamıyoruz. Default değer ataması en soldan atama yaparız. Sağdaki ilk değere atama yapılmaz.
        static int Add2(int x,int number1=20, int number2=30)
        {
            return x + number1 + number2;
          
        }

        // Değer tip olarak aşağıdaki gibi 30 atamamız number 1'i kalıcı olarak yukarıdaki veriyi değiştirmez.
        // Eğer işlemlerde number1'i 30 olarak atamak istiyorsan ref int number1 YA DA out number1 olarak yazmalıyız..!!
        // REF ve OUT arasındaki fark REF'te number ataması yapmamız lazımdır. Fakat OUT'ta böyle bir zorunluluk yoktur.

        static int Add3(int number1, int number2) // static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        // isim değişikliği yapmadan farklı parametlere varsa sorun yoktur.
        // Bu duruma OVERLOAD yani aşırı yükleme denir.
        static int Multiply(int number1, int number2, int number3) 
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[]numbers) // Sayısı çok fazla işlemleri yapmak için uygulanan metotdur. " Params Keyword "
        {
            return numbers.Sum();
        }

        // Metotlar ile tüm verileri tek bir merkezden kontrol etmemize sağlar.
    }
}
