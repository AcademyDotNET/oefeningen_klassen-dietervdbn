using System;

namespace Deel_0_Opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            int kwadraad = KwadraatBerekennen(50);
            int straal = BerekenStraal(2);
            int oppervlak = BerekenOppervlakte(5, 5);
            int grootste = BerekenGrootste(5, 6);
            bool even = ControleEven(6);
            bool armstrongGetal = ControleerArmstrongGetal(9);
            int[] onEvenNummers = ToonOnEvenNummers(50);
            int[] lijstArmstrongNummers = ToonArmstrongNummers(100);
        }

        private static int[] ToonArmstrongNummers(int berijk2)
        {
            int[] lijst = new int[berijk2];
            int plaats = 0;
            for (int i =0;i < berijk2; i++)
            {
                if (ControleerArmstrongGetal(i))
                {
                    lijst[plaats] = i;
                    Console.WriteLine($"{i}");
                    plaats++;
                }
            }
            return lijst;
        }

        private static int[] ToonOnEvenNummers(int berijk)
        {
            int[] lijst = new int[berijk];
            int plaats = 0;
            for (int i = 0; i < berijk; i++)
            {
                if (i%2 ==0)
                {

                }
                else
                {
                    lijst[plaats] = i;
                    plaats++;
                }
            }
            
            return lijst;
        }

        private static bool ControleerArmstrongGetal(int getal)
        {
            int initieelGetal = getal;
            string getalInString = Convert.ToString(getal);
            int lengte = getalInString.Length;
            double supTotaal = 0;

            for (int i = 0; i < lengte; i++)
            {
                int getalTotMacht = getal % 10;
                getal = (getal - getalTotMacht) / 10;
                supTotaal = (supTotaal + Math.Pow(getalTotMacht, lengte));
            }

            if (initieelGetal == supTotaal)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private static bool ControleEven(int v)
        {
            if (v%2 == 0)
            {
                return true;
            }
            else
            {
                return (false);
            }
        }

        private static int BerekenGrootste(int v1, int v2)
        {
            if (v1 > v2)
            {
                return (v1);
            }
            else
            {
                return (v2);
            }
        }

        private static int BerekenOppervlakte(int breedte, int lengte)
        {
            return (breedte * lengte);
        }

        private static int BerekenStraal(int d)
        {
            return (d/2);
        }

        private static int KwadraatBerekennen(int k)
        {
            return (k*k);
        }
    }
}
