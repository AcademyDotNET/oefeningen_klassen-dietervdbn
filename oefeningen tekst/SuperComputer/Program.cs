using System;

namespace SuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het eerste getal?");
            double numberOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef het tweede getal?");
            double numberTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef het derde getal?");
            double numberTree = Convert.ToDouble(Console.ReadLine());

            double gemiddelde = (numberOne + numberTwo + numberTree ) / 3 ;

            Console.WriteLine($"het gemiddelde van de 3cijfers is {gemiddelde}");

        }
    }
}
