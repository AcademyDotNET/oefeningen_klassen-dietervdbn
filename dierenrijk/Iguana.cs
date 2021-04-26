using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Iguana : Reptile
    {
        public Iguana(string naam) : base(naam)
        {
        }
        public bool VerranderdVanKleur { get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            if (VerranderdVanKleur)
            {
                Console.WriteLine($"Dit dier kan zijn huidskleur varranderen");
            }
            else
            {
                Console.WriteLine($"Dit dier kan zijn huidskleur niet varranderen");
            }
        }
        public override string Zegt()
        {
            string zegt = ($"{Name} zegt: kzou et ni weten");
            return zegt;
        }
    }
}
