using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures
{
    abstract class GeometricFigure
    {
        public GeometricFigure()
        {

        }
        public GeometricFigure(int breedte, int hoogte)
        {
            Breedte = breedte;
            Hoogte = hoogte;
        }
        public int Breedte { get; set; }
        public int Hoogte { get; set; }
        public int oppervlakte { get; set; }
        public abstract int BerekenOppervlakte(int breedte, int hoogte);
        public override string? ToString()
        {

            return ($"de breedte is:{Breedte} de hoogte is:{Hoogte} de oppervlakte is:{oppervlakte}");
        }
        public static bool Equals(GeometricFigure figureA, GeometricFigure figureB)
        {
            if (figureA.oppervlakte == figureB.oppervlakte)
                return true;
            return false;
        }
    }
}
