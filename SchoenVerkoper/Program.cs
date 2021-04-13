using System;

namespace SchoenVerkoper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vanaf hoeveel shcoenen is er korting?");
            int korting = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hoeveel schoenen wilt u kopen?");
            int aantalS = Convert.ToInt32(Console.ReadLine());

            int prijsPerSchoen = 10;

            int totalPrice = (aantalS * prijsPerSchoen);

            if (aantalS >= korting)
            {
                int kortingsPrijs = totalPrice - korting;
                Console.WriteLine($"normaal kosten de shcoenen {totalPrice} maar met korting wordt dit {kortingsPrijs}");
            }
            else
            {
                Console.WriteLine($"De shcoenen kosten {totalPrice}.");
            }
        }
    }
}
