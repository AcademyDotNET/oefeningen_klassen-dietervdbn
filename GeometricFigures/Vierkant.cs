using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures
{
    class Vierkant : Rechthoek
    {
        public Vierkant(int breedte, int hoogte)
        {
            if (!(breedte == hoogte)) 
            {
                Hoogte = breedte;
                Breedte = breedte;
            }
        }
        public Vierkant(int breedte)
        {
        }
        public Vierkant()
        {
        }
    }
}
