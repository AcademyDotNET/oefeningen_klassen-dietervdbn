using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("oefening 1 K/D ratio:");
            Console.WriteLine("hoeveel kills heb je behaald?");
            double kills = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hoeveel keer ben je doodgegaan?");
            double deaths = Convert.ToDouble(Console.ReadLine());
            double dkRatio = kills / deaths;
            Console.WriteLine($"je killdeath ratio is {dkRatio}");

            Console.WriteLine("oefening 2 gewicht op planeet:");

            Console.WriteLine("wat is je gewicht in kilo?");
            double gewichtAarde = Convert.ToDouble(Console.ReadLine());

            double gewichtMercurius = gewichtAarde * 0.38;
            Console.WriteLine($"je gewicht op Mercurius is {gewichtMercurius} kilo");

            double gewichtMars = gewichtAarde * 0.38;
            Console.WriteLine($"je gewicht op Mars is {gewichtMars} kilo");

            double gewichtJupiter = gewichtAarde * 2.34;
            Console.WriteLine($"je gewicht op Jupiter is {gewichtJupiter} kilo");

            double gewichtSaturnus = gewichtAarde * 1.06;
            Console.WriteLine($"je gewicht op Saturnus is {gewichtSaturnus} kilo");

            double gewichtUranus = gewichtAarde * 0.92;
            Console.WriteLine($"je gewicht op Uranus is {gewichtUranus} kilo");

            double gewichtNeptunus = gewichtAarde * 1.19;
            Console.WriteLine($"je gewicht op Neptunus is {gewichtNeptunus} kilo");

            double gewichtPluto = gewichtAarde * 0.06;
            Console.WriteLine($"je gewicht op Pluto is {gewichtPluto} kilo");
        }
    }
}
