using System;

namespace PrijzenMetForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prijzen = new double[5];
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine($"geef prijs {i+1}");
                double prijs = Convert.ToInt64(Console.ReadLine());
                prijzen[i] = prijs;
            }
            double totaal = 0;
            foreach (double prijs in prijzen)
            {
                totaal += prijs;
                if (prijs > 5)
                {
                    Console.WriteLine($"{prijs}");
                }
            }
            double gemiddelde = totaal / prijzen.Length;
            Console.WriteLine($"Het gemiddelde is: {gemiddelde}");
        }
    }
}
