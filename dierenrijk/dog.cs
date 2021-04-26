using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class dog : Mammal
    {
        public dog(string naam) : base(naam)
        {
        }
        public string Ras { get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Deze hond is van het ras: {Ras}");
        }
        public override string Zegt()
        {
            string zegt = ($"{Name} zegt: woef");
            return zegt;
        }
    }
}
