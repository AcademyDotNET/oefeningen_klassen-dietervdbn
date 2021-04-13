using System;

namespace oefening3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("geef het bedrag in euro?");
            double euroPrijs = Convert.ToDouble(Console.ReadLine());

            double dollarPrijs = (euroPrijs * 0.89);
            Console.WriteLine($"De prijs in dollar is {dollarPrijs}");
        }

    }
}
