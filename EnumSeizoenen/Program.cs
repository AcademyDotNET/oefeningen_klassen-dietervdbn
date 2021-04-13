using System;

namespace EnumSeizoenen
{
    enum Seizoenen { lente, zomer, herfst, winter}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een maandnummer in?");
            int monthNr = Convert.ToInt32(Console.ReadLine());
            switch (monthNr)
            {
                case int n when (n == 1 || n == 2 || n == 12):
                    Console.WriteLine($"Deze maand valt in het seizoen {Seizoenen.winter}");
                    break;

                case int n when (n == 3 || n == 4 || n == 5):
                    Console.WriteLine($"Deze maand valt in het seizoen {Seizoenen.lente}");
                    break;

                case int n when (n == 6 || n == 7 || n == 8):
                    Console.WriteLine($"Deze maand valt in het seizoen {Seizoenen.zomer}");
                    break;

                case int n when (n == 9 || n == 10 || n == 11):
                    Console.WriteLine($"Deze maand valt in het seizoen {Seizoenen.herfst}");
                    break;

                default:
                    Console.WriteLine("foute ingave!");
                    break;
            }
        }
    }
}
