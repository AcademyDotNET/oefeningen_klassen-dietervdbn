using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures
{
    class Rechthoek : GeometricFigure
    {
        public Rechthoek()
        {

        }
        public Rechthoek(int breedte, int hoogte) : base(breedte, hoogte)
        {

        }
        public override int BerekenOppervlakte(int breedte, int hoogte)
        {
            int opp = breedte * hoogte;
            return opp;
        }

    }
}
