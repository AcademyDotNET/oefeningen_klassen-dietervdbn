using System;

namespace LeveringsBedrijf
{
    class Program
    {
        static void Main(string[] args)
        {
            int [ , ] postCodes = 
                {
                {1000,2000,3000,3020,4000,5000,6000,7000,8000,9000},
                {5,6,8,9,5,3,2,3,1,5}
            };

            Console.WriteLine($"wNaar welke pastcode stuur je je pakje?");
            int postcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"wat is het gewicht van je pakje?");
            int gewicht = Convert.ToInt32(Console.ReadLine());
            int kostPrijs = controlleerPrijs(postcode, gewicht, postCodes);
            Console.WriteLine($"de totale kost is; {kostPrijs}");

        }

        private static int controlleerPrijs(int postcode, int gewicht, int[,] postCodes)
        {
            int prijs = 0;
            int top = postCodes.GetUpperBound(1)+1;
            for (int i = 0; i < top; i++)
            {
                if (postcode == postCodes[0,i]) 
                {
                    prijs = (gewicht * postCodes[1,i]);
                }
            }
            return prijs;
        }
    }
}
