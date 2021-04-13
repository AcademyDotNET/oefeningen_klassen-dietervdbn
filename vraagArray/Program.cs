using System;

namespace vraagArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vragen = { "hoeveel is 9+1", "hoeveel is 9+2", "hoeveel is 9+3", "hoeveel is 9+4", "hoeveel is 9+5", "hoeveel is 9+6" };
            int[] antwoorden = new int[6];

            for (int i = 0; i < vragen.Length; i++)
            {
                Console.WriteLine($"{vragen[i]}? ");
                int getal = Convert.ToInt32(Console.ReadLine());
                antwoorden[i] = getal;
            }
            for (int i = 0; i < vragen.Length; i++)
            {
                Console.WriteLine($"{vragen[i]}? antwoord: {antwoorden[i]}");
            }
        }
    }
}
