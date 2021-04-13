using System;

namespace ArrayZoeker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallenReeksA = GeefGetallenIn();
            int[] getallenReeksB = VerwijderGetal(getallenReeksA);
            ToonGetallen(getallenReeksA);
            Console.WriteLine($"");
            ToonGetallen(getallenReeksB);

        }

        private static void ToonGetallen(int[] getallenReeks)
        {
            for (int i = 0; i < getallenReeks.Length; i++)
            {
                Console.WriteLine($"{getallenReeks[i]}");
            }
        }

        private static int[] VerwijderGetal(int[] getallenReeks)
        {
            int[] getallenLijst = new int[10];
            Console.WriteLine($"welk getal wil je verwijderen?");
            int getal = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < getallenReeks.Length; i++)
            {
                getallenLijst[i] = getallenReeks[i];

                if (getallenReeks[i] == getal)
                {
                    for (int j = i; (j < getallenLijst.Length -1); j++)
                    {
                        getallenLijst[j] = getallenReeks[j + 1];
                    }
                    getallenLijst[getallenLijst.Length-1] = -1;
                    break;
                }
            }
            return getallenLijst;

        }

        private static int[] GeefGetallenIn()
        {
            int[] getallenLijst = new int[10];

            for (int i = 0; i < getallenLijst.Length; i++)
            {
                Console.WriteLine($"geef getal {i + 1} ");
                int getal = Convert.ToInt32(Console.ReadLine());
                getallenLijst[i] = getal;
            }
            return getallenLijst;
        }
    }
}
