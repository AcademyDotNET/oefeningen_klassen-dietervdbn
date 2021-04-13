using System;

namespace oefening5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoeveel kills heb je behaald?");
            double kills = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hoeveel keer ben je doodgegaan?");
            double deaths = Convert.ToDouble(Console.ReadLine());
            double dkRatio = kills / deaths;
            Console.WriteLine($"je killdeath ratio is {dkRatio}");
        }
    }
}
