using System;

namespace ArrayOefener1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = GeefGetallenIn();
            controlleerGetal(getallen);
        }

        private static void controlleerGetal(int[] getallen)
        {
            Console.WriteLine($"geef je getal");
            int getal = Convert.ToInt32(Console.ReadLine());
            bool check = false;

            for (int i = 0; i < getallen.Length; i++)
            {
                if (getal <= getallen[i])
                {
                    Console.WriteLine($"{getallen[i]}");
                    check = true;
                }
            }
            if (!(check))
            {
                Console.WriteLine($"Niets is groter");
            }

        }

        private static int[] GeefGetallenIn()
        {
            int[] getallenLijst = new int[10];
            int som = 0;
            double gemiddelde = 0;
            int grootste = 0;

            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine($"geef getal nummer {i + 1} ");
                int getal = Convert.ToInt32(Console.ReadLine());
                getallenLijst[i] = getal;
                som += getal;
                if (getal>grootste)
                {
                    grootste = getal;
                }
            }
            gemiddelde = som / 10;
            Console.WriteLine($"de som is: {som}");
            Console.WriteLine($"het gemiddelde is: {gemiddelde}");
            Console.WriteLine($"Het grootste getal is: {grootste}");
            return getallenLijst;

        }
    }
}
