using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class dog : Mammal
    {
        public string Ras { get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Deze hond is van het ras: {Ras}");
        }
    }
}
