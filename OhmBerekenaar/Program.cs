using System;

namespace OhmBerekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wat wil je berekennen: spanning, weerstand of stroomsterkte?");
            string choise = Console.ReadLine();


            switch (choise)
            {
                case "spanning":
                    Console.WriteLine("wat is de weerstand?");
                    int weerstandOne = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("wat is de stroomsterkte?");
                    int stroomsterkteOne = Convert.ToInt32(Console.ReadLine());

                    double resultSpa = stroomsterkteOne * weerstandOne;

                    Console.WriteLine($"De spanning bedraagd {resultSpa} volt.");
                    break;

                case "weerstand":
                    Console.WriteLine("wat is de spanning?");
                    int spanningTwo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("wat is de stroomsterkte?");
                    int stroomsterkteTwo = Convert.ToInt32(Console.ReadLine());

                    double resultWe = spanningTwo / stroomsterkteTwo;

                    Console.WriteLine($"De weerstand bedraagd {resultWe} Ohm.");
                    break;

                case "stroomsterkte":
                    Console.WriteLine("wat is de spanning?");
                    int spanningTree = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("wat is de weerstand?");
                    int weerstandTree = Convert.ToInt32(Console.ReadLine());

                    double resultSt = spanningTree / weerstandTree;

                    Console.WriteLine($"De weerstand bedraagd {resultSt} ampère.");
                    break;
                default:
                    Console.WriteLine($"foute ingave.");
                    break;
            }
        }
    }
}
