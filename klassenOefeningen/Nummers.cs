using System;
using System.Collections.Generic;
using System.Text;

namespace klassenOefeningen
{
    class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        public int Som()
        {
            int som = Getal1 + Getal2;
            return som;
        }
        public int Verschil()
        {
            int som = Getal1 - Getal2;
            return som;
        }
        public int Product()
        {
            int som = Getal1 * Getal2;
            return som;
        }
        public double Quotient()
        {
            double som = 0;
            if (Getal2 == 0)
            {
                Console.WriteLine("Deling door 0 is niet mogelijk"); 
            }
            else
            {
                som = Getal1 / Getal2;
            }
            return som;
        }
    }
}
