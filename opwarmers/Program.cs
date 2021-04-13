using System;

namespace opwarmers
{
    class Program
    {
        private static int[] maakGetallen0Naar100()
        {
            int[] getallenLijst = new int[101];
            for (int i = 0; i<101;i++)
            {
                getallenLijst[i] = i;
                Console.Write(i);
            }
            return getallenLijst;
        }

        static void Main(string[] args)
        {
            int[] getallen0Naar100 = maakGetallen0Naar100();
            Console.WriteLine();
            int[] getallen100Naar0 = maakGetallen100Naar0();
            Console.WriteLine();
            char[] alfabet = maakalfabet();
            Console.WriteLine();
            int[] randomNumbers = ArrayRandomNumbers();
            Console.WriteLine();
            bool[] booleans = randomBooleans();
        }

        private static bool[] randomBooleans()
        {
            bool[] lijst = new bool[30];

            for (int i = 0; i < 30; i++)
            {
                if (i % 2 == 0)
                {
                    lijst[i] = false;
                    Console.Write(lijst[i]);
                }
                else
                {
                    lijst[i] = true;
                    Console.Write(lijst[i]);
                }
            }
            return lijst;
        }

        private static int[] ArrayRandomNumbers()
        {
            Random ranNum = new Random();
            int[] lijst = new int[20];

            for (int i = 0; i < 20; i++)
            {
                lijst[i] = ranNum.Next(1, 101);
                Console.Write(lijst[i]);
            }
            return lijst;
        }

        private static int[] maakGetallen100Naar0()
        {
            int[] getallenLijst = new int[101];
            for (int i = 100; i >= 0; i--)
            {
                getallenLijst[i] = i;
                Console.Write(i);
            }
            return getallenLijst;
        }
        private static char[] maakalfabet()
        {
            char[] alfabet = new char[27];
            for (int i = 97; i < 123; i++)
            {
                char letter;
                letter = (char)i;
                alfabet[i-97] = letter;
                Console.Write((char)i);
            }
            return alfabet;
        }
    }
}
