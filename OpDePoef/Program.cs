using System;

namespace OpDePoef
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalbill = 0;


            totalbill = RekeningBerekening(totalbill);
            totalbill = RekeningBerekening(totalbill);
            totalbill = RekeningBerekening(totalbill);
            totalbill = RekeningBerekening(totalbill);
            totalbill = RekeningBerekening(totalbill);

            int weeks = (int)totalbill /10;
            Console.WriteLine($"Het totaal van  de poef is {totalbill} en zal {weeks} weken duren om volledig afbetaald te worden.");
        }

        public static double RekeningBerekening(double totalbill)
        {
            Console.WriteLine("wat is je rekening?");
            double bill = Convert.ToDouble(Console.ReadLine());

            totalbill = totalbill + bill;

            Console.WriteLine($"De poef staat op {totalbill}");
            return totalbill;

        }
    }
}
