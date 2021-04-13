using System;
using System.Collections.Generic;
using System.Text;

namespace Figuren
{
    class Rechthoek
    {
        public int Lengte
        {
            get
            {
                return Lengte;
            }
            set
            {
                Lengte = IngaveLengte();
            }
        }
        public int IngaveLengte()
        {
            int lengte;
            do
            {
                Console.WriteLine($"Ingave lengte");
                lengte = Convert.ToInt32(Console.ReadLine());
            } while (lengte < 1);
            return lengte;
        }

        public int breedte
        {
            get
            {
                return breedte;
            }
            set
            {
                breedte = Ingavebreedte();
            }
        }
        public int Ingavebreedte()
        {
            int breedte = 0;
            do
            {
                Console.WriteLine($"Ingave breedte");
                breedte = Convert.ToInt32(Console.ReadLine());
            } while (breedte < 1);
            return breedte;
        }
        public void ToonOppervlakte()
        {
            int oppervlakte = (breedte * Lengte);
            Console.WriteLine($"De oppervlakte is: {oppervlakte}");
        }
    }
}
