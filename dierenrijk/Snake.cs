using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Snake : Reptile
    {
        public Snake(string naam) : base(naam)
        {
        }
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
        public override string Zegt()
        {
            string zegt = ($"{Name} zegt: sssssssssssss");
            return zegt;
        }
    }
}
