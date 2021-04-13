using System;

namespace parkeerGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"hoeveel auto's?");
            int aantal = Convert.ToInt32(Console.ReadLine());

            double [] lijstTijden = IngaveAutos(aantal);

            Output(lijstTijden);
        }

        private static void Output(double[] lijstTijden)
        {
            double som = 0;
            for (int i = 0; i < lijstTijden.Length; i++)
            {
                double kostprijs = BerekenPrijs(lijstTijden[i]);
                som += kostprijs;
                Console.WriteLine($"auto {i}: {kostprijs} /€.");
            }
            Console.WriteLine($"de totale som is {som}");
        }

        private static double[] IngaveAutos(int aantal)
        {
            double[] lijst = new double[aantal];
            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine($"Geef parkeertijd auto {i+1} in (uren):");
                double duur = Convert.ToDouble(Console.ReadLine());
                lijst[i] = duur;
            }
            return lijst;
        }

        private static double BerekenPrijs(double duur)
        {
            double kost = 0;
            if(duur < 3)
            {
                kost = 2;
            }
            else
            {
                kost = 2 + ((duur-3) * 0.5);
            }
            if (kost > 10)
            {
                kost = 10;
            }
            return kost;
        }
    }
}
