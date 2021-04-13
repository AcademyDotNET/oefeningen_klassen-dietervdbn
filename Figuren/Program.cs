using System;

namespace Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek hoekje = new Rechthoek();
            hoekje.Lengte = hoekje.IngaveLengte();
            hoekje.breedte = hoekje.Ingavebreedte();

            hoekje.ToonOppervlakte();

            Driehoek driehoekje = new Driehoek();
            driehoekje.Basis = driehoekje.IngaveBasis();
            driehoekje.Hoogte = driehoekje.IngaveHoogte();

            driehoekje.ToonOppervlakte();
        }
    }
}
