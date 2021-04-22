using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Iguana : Reptile
    {
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
    }
}
