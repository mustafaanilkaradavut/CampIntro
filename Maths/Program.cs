using System;

namespace Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                FourOperation fourOperations = new FourOperation();
                
                fourOperations.Plus(5, 6);
                fourOperations.Plus(4100, 6400);
            }
        }
    }
}
