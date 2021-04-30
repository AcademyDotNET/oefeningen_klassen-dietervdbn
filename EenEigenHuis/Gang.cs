using System;
using System.Collections.Generic;
using System.Text;

namespace EenEigenHuis
{
    class Gang : Kamer
    {
        public Gang()
        {
            Prijs = oppervlakte * 10;
        }
    }
}
