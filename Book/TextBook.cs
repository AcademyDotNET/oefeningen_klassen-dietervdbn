using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class TextBook : Book
    {
        public TextBook()
        {
            while (Price < 20 || Price > 80)
            {
                Console.WriteLine($"geef een prijs tussen 20 en 80?");
                Price = Convert.ToInt32(Console.ReadLine());
            }
        }
        public int GradeLevel { get; set; }
    }
}
