using System;

namespace FeestKassa
{
    class Program
    {
        static void Main(string[] args)
        {
            double ijs = 3;
            double mosselen = 20;
            double koninginnehapje = 10;
            double drankien = 2;

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

        }
    }
}
