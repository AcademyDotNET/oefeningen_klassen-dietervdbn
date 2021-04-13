using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int punten = 0;

            Console.WriteLine("Welkom op de quiz!");
            Console.WriteLine("1ste vraag: in welk jaar is Nelson Mandela gestorven?");
            Console.WriteLine("A:1998, B:2003, C:2007, D:2013");
            char answerOne = Convert.ToChar(Console.ReadLine());

            switch (answerOne)
            {
                case 'A':
                    Console.WriteLine("jammer het goede antwoord was D");
                    punten = punten - 1;
                    break;

                case 'B':
                    Console.WriteLine("jammer het goede antwoord was D");
                    punten = punten - 1;
                    break;

                case 'C':
                    Console.WriteLine("jammer het goede antwoord was D");
                    punten = punten - 1;
                    break;

                case 'D':
                    Console.WriteLine("Correct!");
                    punten = punten + 2;
                    break;

                default:
                    Console.WriteLine("foute ingave!");
                    break;
            }

            Console.WriteLine("welke belgische voetbalploeg won in 1988 de europese beker voor bekerwinnaars?");
            Console.WriteLine("A:Standard Luik, B:kv mechelen, C:RSC Anderlecht, D:Club Brugge");
            char answerTwo = Convert.ToChar(Console.ReadLine());

            switch (answerTwo)
            {
                case 'A':
                    Console.WriteLine("jammer het goede antwoord was B");
                    punten = punten - 1;
                    break;

                case 'B':
                    Console.WriteLine("Correct!");
                    punten = punten + 2;
                    break;

                case 'C':
                    Console.WriteLine("jammer het goede antwoord was B");
                    punten = punten - 1;
                    break;

                case 'D':
                    Console.WriteLine("jammer het goede antwoord was B");
                    punten = punten - 1;
                    break;

                default:
                    Console.WriteLine("foute ingave!");
                    break;
            }

            Console.WriteLine("welk huidig land hoorde niet bij de soviet unie?");
            Console.WriteLine("A:Moldavië, B:Oezbekistan, C:Armenië, D:Roemenië");
            char answerTree = Convert.ToChar(Console.ReadLine());

            switch (answerTree)
            {
                case 'A':
                    Console.WriteLine("jammer het goede antwoord was D");
                    punten = punten - 1;
                    break;

                case 'B':
                    Console.WriteLine("jammer het goede antwoord was D");
                    punten = punten - 1;
                    break;

                case 'C':
                    Console.WriteLine("jammer het goede antwoord was D");
                    punten = punten - 1;
                    break;

                case 'D':
                    Console.WriteLine("correct!");
                    punten = punten + 2;
                    break;

                default:
                    Console.WriteLine("foute ingave!");
                    break;
            }
            Console.WriteLine($"je behaalde {punten} punten.");
        }
    }
}
