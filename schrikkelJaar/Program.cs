using System;

namespace schrikkelJaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een jaartal?");
            int year = Convert.ToInt32(Console.ReadLine());

            int test = (year % 4);
            int testTwo = (year % 100);
            int testTree = (year % 400);

            if (test == 0)
            {
                if (testTree == 0)
                {
                    Console.WriteLine("Schrikkeljaar");
                }
                else if (testTwo == 0)
                {
                    Console.WriteLine("Dit is geen schrikkeljaar");
                }
                else
                {
                    Console.WriteLine("schrikkeljaar");
                }
            }
            else
            {
                Console.WriteLine("Dit is geen schrikkeljaar");
            }
        }
    }
}
