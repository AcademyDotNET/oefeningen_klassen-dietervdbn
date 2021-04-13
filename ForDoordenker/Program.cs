using System;

namespace ForDoordenker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een getal in:");
            int getal = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < getal; i++) 
            {
                for (int j =0; j<= i; j++)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();

            }
            for (int i = getal; i > 0; i--)
            {
                for (int j = i - 1; j > 0; j--)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();

            }

        }
    }
}
