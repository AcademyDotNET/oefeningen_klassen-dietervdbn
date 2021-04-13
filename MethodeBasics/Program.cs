using System;

namespace MethodeBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Myintro("dieter Vanderbemden", 29, "klein dalenstraat");
            int grootste = BerekenGrootste(5, 6, 6);
            Console.WriteLine();
            int lengtePassw = 6;
            char[] passwoord = PasswGenerator(lengtePassw);
            Console.Write($"je nieuw paswoord is: ");
            for (int j = 0; j < lengtePassw; j++)
            {
                Console.Write($"{passwoord[j]}");
            }
            Console.WriteLine();
        }

        private static char[] PasswGenerator(int lengte)
        {
            char[] karacters = new char [lengte];
            Random rangen = new Random();
            for (int i =0; i < lengte; i++)
            {
                int keuze = rangen.Next(0, 3);
                if (keuze == 1)
                {
                    char hoofdLetter = Convert.ToChar(rangen.Next(65, 91));
                    karacters[i] = hoofdLetter;
                }
                else if (keuze == 2)
                {
                    char kleineLetter = Convert.ToChar(rangen.Next(97, 123));
                    karacters[i] = kleineLetter;
                }
                else
                {
                    char teken = Convert.ToChar(rangen.Next(33, 65));
                    karacters[i] = teken;
                }
            }
            return karacters;

        }

        private static void Myintro(string naam, int leeftijd, string plaats)
        {
            Console.WriteLine($"Ik ben {naam}, ik ben {leeftijd} jaar oud en woon in de {plaats}");
        }
        private static int BerekenGrootste(int v1, int v2, int v3)
        {
            if (v1 > v2)
            {
                if (v1 > v3)
                {
                    return (v1);
                }
                else
                {
                    return (v3);
                }
            }
            else
            {
                if (v2 > v3)
                {
                    return (v2);
                }
                else
                {
                    return (v3);
                }
            }
        }
    }
}
