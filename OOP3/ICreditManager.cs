using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager  // Interface konusunu işleyeceğiz OOP3'te. Başına "I" getiririz. Burası BASE CLASS'TIR.
    {
        void Calculate();
        void DoSomething();
    }
        // Loglama : Kim ne zaman nereye hangi operasyonu çağırdığıdır. 
        // Logları bir dosya'da tutabiliriz, bir veride tutabiliriz. SMS gönderebiliriz. E-posta gönderme kodları yazılabilir.
}
