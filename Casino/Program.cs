using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genAge = new Random();
            int Number = genAge.Next(1, 2);

            Console.WriteLine("wat denk je dat het getal is?");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == Number)
            {
                Console.WriteLine("Proficiat goed gegokt, maar om het casino te verslaan moet je nog 2keer juist raden, volgend getal?");
                int guessTwo = Convert.ToInt32(Console.ReadLine());
                int NumberTwo = genAge.Next(1, 2);

                if (guessTwo == NumberTwo)
                {
                    Console.WriteLine("Proficiat opnieuw goed gegokt, maar om het casino te verslaan moet je nog een keer juist raden, volgend getal?");
                    int guessTree = Convert.ToInt32(Console.ReadLine());
                    int NumberTree = genAge.Next(1, 2);

                    if (guessTree == NumberTree)
                    {
                        Console.WriteLine("wow je hebt het casino verslaan!");
                    }
                    else
                    {
                        Console.WriteLine("jammer, geld kwijt!");
                    }
                }
                else
                {
                    Console.WriteLine("jammer, geld kwijt!");
                }

            }
            else
            {
                Console.WriteLine("jammer, geld kwijt!");
            }
        }
    }
}
