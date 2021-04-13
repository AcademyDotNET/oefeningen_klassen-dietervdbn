using System;
using System.Collections.Generic;
using System.Text;

namespace Figuren
{
    class Driehoek
    {
        public int Basis
        {
            get
            {
                return Basis;
            }
            set
            {
                Basis = IngaveBasis();
            }
        }
        public int IngaveBasis()
        {
            int basis = 0;
            do
            {
                Console.WriteLine($"Ingave lengte");
                basis = Convert.ToInt32(Console.ReadLine());
            } while (basis < 1);
            return basis;
        }

        public int Hoogte
        {
            get
            {
                return Hoogte;
            }
            set
            {
                Hoogte = IngaveHoogte();
            }
        }
        public int IngaveHoogte()
        {
            int hoogte = 0;
            do
            {
                Console.WriteLine($"Ingave breedte");
                hoogte = Convert.ToInt32(Console.ReadLine());
            } while (hoogte < 1);
            return hoogte;
        }
        public void ToonOppervlakte()
        {
            int oppervlakte = (Basis * Hoogte);
            Console.WriteLine($"De oppervlakte is: {oppervlakte}");
        }
    }
}
