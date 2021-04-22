using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Mammal : Animal
    {
        public int AantalPoten{ get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Het dier heeft {AantalPoten} poten");
        }
    }
}
