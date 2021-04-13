using System;

namespace BeacomeNeo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rangen = new Random();
            Random ranCollor = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                //Genereer nieuw random teken:
                char teken = Convert.ToChar(rangen.Next(62, 400));
                //Zet teken op scherm

                //Ietwat vertragen
                System.Threading.Thread.Sleep(10); //dit getal is in milliseconden. Speel er gerust mee.
                int collor = ranCollor.Next(1, 9);
                switch (collor)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(teken);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(teken);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(teken);
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(teken);
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(teken);
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(teken);
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(teken);
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(teken);
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(teken);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(teken);
                        break;
                }

                //Af en toe donker kleurtje
                if (rangen.Next(0, 3) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

        }
    }
}
