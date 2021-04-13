using System;

namespace Boekhouder
{
    class Program
    {
        static void Main(string[] args)
        {
            int balans = 0;
            int negatieveWaarde = 0;
            int positieveWaarde = 0;
            int gemiddeldeWaarde = 0;
            int teller = 0;
            int getal = 0;
            do
            {
                Console.WriteLine("geef een getal in (0 om te stoppen)");
                getal = Convert.ToInt32(Console.ReadLine());
                balans += getal;
                if (getal < 0)
                {
                    negatieveWaarde += getal;
                }
                else
                {
                    positieveWaarde += getal;
                }
                gemiddeldeWaarde += getal;
                teller++;
            } while (getal != 0);
            Console.WriteLine($"De balans is {balans}");
            Console.WriteLine($"De totale negatieve waarde is {negatieveWaarde}");
            Console.WriteLine($"De totale positieve waarde is {positieveWaarde}");
            Console.WriteLine($"het gemiddelde is {gemiddeldeWaarde}");

        }
    }
}
