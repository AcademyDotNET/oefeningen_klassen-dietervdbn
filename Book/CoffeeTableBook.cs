using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class CoffeeTableBook :Book
    {
        public CoffeeTableBook()
        {
            while (Price < 35 || Price > 100)
            {
                Console.WriteLine($"geef een prijs tussen 35 en 100?");
                Price = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
