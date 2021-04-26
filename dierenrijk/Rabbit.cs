using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Rabbit : Mammal
    {
        public Rabbit(string naam) : base(naam)
        {
        }
        public bool EetGraagWortels { get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            if (EetGraagWortels)
            {
                Console.WriteLine($"een konijn eet graag wortels");
            }
            else
            {
                Console.WriteLine($"Dit konijn lust geen wortels");
            }
        }
        public override string Zegt()
        {
            string zegt = ($"{Name} zegt: kzou et ni weten");
            return zegt;
        }
    }
}
