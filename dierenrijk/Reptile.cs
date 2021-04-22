using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Reptile : Animal
    {
        public int AantalSchubben { get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Het dier heeft {AantalSchubben} schubben");
        }
    }
}
