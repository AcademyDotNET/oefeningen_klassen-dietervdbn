using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures
{
    class Driehoek : GeometricFigure
    {
        public Driehoek(int breedte, int hoogte) : base(breedte, hoogte)
        {

        }
        public Driehoek()
        {

        }
        public override int BerekenOppervlakte(int breedte, int hoogte)
        {
            int opp = (breedte * hoogte)/2;
            return opp;
        }
    }
}
