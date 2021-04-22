using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Snake : Reptile
    {
        public bool Verveld { get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            if (Verveld)
            {
                Console.WriteLine($"Dit dier kan Vervellen");
            }
            else
            {
                Console.WriteLine($"Dit dier kan niet Vervellen");
            }
        }
    }
}
