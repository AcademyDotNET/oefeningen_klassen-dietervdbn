using System;

namespace WeerstandBerekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef de kleurcode van de 1ste ring");
            int ringOne = Convert.ToInt32(Console.ReadLine());

            GeefKleurTerug(ringOne);

            Console.WriteLine("geef de kleurcode van de 2de ring");
            int ringTwo = Convert.ToInt32(Console.ReadLine());

            GeefKleurTerug(ringTwo);

            Console.WriteLine("geef de kleurcode van de 3de ring");
            int ringTree = Convert.ToInt32(Console.ReadLine());

            GeefKleurTerug(ringTree);

            double weerstand = ((ringOne * 10) + ringTwo) * (Math.Pow(10, ringTree));
            Console.WriteLine($"De totale weerstand is {weerstand} Ohm.");

            string output = @$"╔═══════════════╦═══════════════╗
║ de totale weerstand is
╟───────────────╫───────────────╢
║ {weerstand}             Ohm
╚═══════════════╩═══════════════╝";
            Console.WriteLine(output);

        }
        static void GeefKleurTerug(int color)
        {
            if (color == 0)
            {
                Console.WriteLine("de code komt overeen met zwart");
            }
            else if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("de code komt overeen met bruin");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("de code komt overeen met rood");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("de code komt overeen met oranje");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("de code komt overeen met geel");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("de code komt overeen met groen");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 6)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("de code komt overeen met blauw");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 7)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("de code komt overeen met paars");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 8)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("de code komt overeen met grijs");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 9)
            {
                Console.WriteLine("de code komt overeen met wit");
            }

        }
    }
}
