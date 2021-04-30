using System;
using System.Collections.Generic;
using System.Text;

namespace EenEigenHuis
{
    class Salon : Kamer
    {
        public Salon()
        {
            if (schouw)
            {
                Prijs = 500;
            }
            else
            {
                Prijs = 300;
            }
        }
    }
}
