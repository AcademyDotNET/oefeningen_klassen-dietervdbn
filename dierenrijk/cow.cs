using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class cow : Mammal
    {
        public int  AantalMagen { get; set; }
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"Een koe heeft {AantalMagen} magen");
        }
    }
}
