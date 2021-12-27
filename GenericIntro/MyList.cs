using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    internal class MyList<T>
    {
        T[] items;                                // Class'ın tüm metotlarına erişebilecek bir dizi tasarlıyoruz.
        public MyList()                          // ctor + tab + tab yaparak elde ettik. Bu duruma " Constructor " deniyor.
        {
                items = new T[0];
        }
        public void Add(T item)                  // Ben sana ne veriyorsam, ne yazıyorsam verdiğim elemanın türüde odur.
        {
            T[] tempArray = items;               // TempArray = Geçici dizi demektir.
            items = new T[items.Length + 1];     // Mevcuttaki eleman sayısı bir arttır demek.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];         // Bu işlemle "items" eski değerlerine tekrar sahip oldu.
            }

            items[items.Length-1] = item;
        }
        
    }
}
