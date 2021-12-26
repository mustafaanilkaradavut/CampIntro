using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // snippet ; hazır kodlar demektir.
    // Id diye başlayan referans alanları genellikle ilk sıralara yazılır. Maksat kod okunurluluğunu arttırmaktır.
    internal class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        // CRUD - Create - Read - Update - Delete, Otomasyon Projelerinde konuşulan bir terimdir.

    }
}
