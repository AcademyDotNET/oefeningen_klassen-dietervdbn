using System;

namespace Oefening1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int resoltA = oefA();
            Console.WriteLine($"het resultaat is {resoltA}");

            int resoltB = oefB();
            Console.WriteLine($"het resultaat is {resoltB}");

            int resoltC = oefC();
            Console.WriteLine($"het resultaat is {resoltC}");

            int resoltD = oefD();
            Console.WriteLine($"het resultaat is {resoltD}");

            double doubleA = 0;
            doubleA = (-1 + 4 * 6);
            Console.WriteLine($"het resultaat is {doubleA}");

            double doubleB = 0;
            doubleB = ((35 + 5) % 7);
            Console.WriteLine($"het resultaat is {doubleB}");

            double doubleC = 0;
            doubleC = (14 + -4 * 6 / 11);
            Console.WriteLine($"het resultaat is {doubleC}");

            double doubleD = 0;
            doubleD = (2 + 15 / 6 * 1 - 7 % 2);
            Console.WriteLine($"het resultaat is {doubleD}");



        }
        static int oefA()
        {
            int resoltA;
            resoltA = (-1 + 4 * 6);
            return resoltA;
        }
        static int oefB()
        {
            int resoltB;
            resoltB = ((35 + 5) % 7);
            return resoltB;
        }
        static int oefC()
        {
            int resoltC;
            resoltC = (14 + -4 * 6 / 11);
            return resoltC;
        }
        static int oefD()
        {
            int resoltD;
            resoltD = (2 + 15 / 6 * 1 - 7 % 2);
            return resoltD;
        }
    }
}