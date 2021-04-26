using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Mammal : Animal
    {
        public Mammal(string naam) : base(naam)
        {
        }
        public int AantalPoten{ get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Het dier heeft {AantalPoten} poten");
        }
        public override string Zegt()
        {
            string zegt = "";
            return zegt;
        }
    }
}
