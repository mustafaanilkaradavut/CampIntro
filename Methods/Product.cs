using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    internal class Product
    {
        // Bunlar "property" yazılarak oluşturulan ögelerdir. Anlamı özelliktir.
        public int Id { get; set; } // ID bir datayı diğerlerinden ayırt etmek için kullanılan bilgidir.
        public string Name { get; set; }
        public double Price { get; set; }
        public string Information { get; set; }

        public int UnitCapacity { get; set; }
    }
}
