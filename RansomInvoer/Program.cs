using System;

namespace RansomInvoer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rando = new Random();
            int ijs = rando.Next(1, 5);
            int mosselen = rando.Next(12, 35);
            int koninginnehapje = rando.Next(10, 18);
            int drankien = rando.Next(1, 6);

            //double ijs = 3;
            //double mosselen = 20;
            //double koninginnehapje = 10;
            //double drankien = 2;

            Console.WriteLine("hoeveel schotels mosselen?");
            int aantalM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hoeveel schotels koninginnehapjes?");
            int aantalk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hoeveel ijsjes?");
            int aantalI = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hoeveel dranken?");
            int aantalD = Convert.ToInt32(Console.ReadLine());

            double total = (aantalM * mosselen) + (aantalk * koninginnehapje) + (aantalI * ijs) + (aantalD * drankien);

            Console.WriteLine($"Het totaal te betalen bedrag is {total} EURO.");
            Console.WriteLine($"De prijs van de mosselen was {mosselen} EURO.");
            Console.WriteLine($"De prijs van de koninginnehapjes was {koninginnehapje} EURO.");
            Console.WriteLine($"De prijs van het ijs was {ijs} EURO.");
            Console.WriteLine($"De prijs van de drank was {drankien} EURO.");

        }
    }
}
