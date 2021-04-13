using System;

namespace ArrayOefener2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallenA = GeefGetallenIn();
            int[] getallenB = GeefGetallenIn();
            int[] getallenC = TelGetallenOp(getallenA, getallenB);
        }

        private static int[] TelGetallenOp(int[] getallenA, int[] getallenB)
        {
            int[] getallenLijst = new int[5];

            for (int i = 0; i < getallenLijst.Length; i++)
            {

                getallenLijst[i] = (getallenA[i] + getallenB[i]);
                Console.WriteLine($"getal {i + 1} = {getallenLijst[i]}");
            }
            return getallenLijst;
        }

        private static int[] GeefGetallenIn()
        {
            int[] getallenLijst = new int[5];

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
