using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Reptile : Animal
    {
        public Reptile(string naam) : base(naam)
        {
        }
        public int AantalSchubben { get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Het dier heeft {AantalSchubben} schubben");
        }
        public override string Zegt()
        {
            string zegt = "";
            return zegt;
        }
    }
}
