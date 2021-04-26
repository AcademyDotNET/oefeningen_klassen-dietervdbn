using System;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek = new Rechthoek(5,6);
            Vierkant vierkant = new Vierkant(5,6);
            Driehoek driehoek = new Driehoek(5,6);


            Console.WriteLine($"{rechthoek.BerekenOppervlakte(rechthoek.Breedte, rechthoek.Hoogte)}");
            Console.WriteLine($"{vierkant.BerekenOppervlakte(vierkant.Breedte, vierkant.Hoogte)}");
            Console.WriteLine($"{driehoek.BerekenOppervlakte(driehoek.Breedte, driehoek.Hoogte)}");
        }
    }
}
