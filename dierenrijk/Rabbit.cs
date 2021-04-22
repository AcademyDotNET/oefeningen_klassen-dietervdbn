using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Rabbit : Mammal
    {
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
    }
}
