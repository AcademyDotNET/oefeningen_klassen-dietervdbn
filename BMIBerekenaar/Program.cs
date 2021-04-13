using System;

namespace BMIBerekenaar
{
    enum Bmi { ondergewicht, normaalGewicht, overgewicht, Zwaarlijvigheid, ernstigeZwaarlijvigheid }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wat is je lengte (in meter)?");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is je gewicht (in kg)?");
            double mass = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Black;
            double bmi = Math.Round(mass/(length * length),2);
            //Console.WriteLine($"Je BMI is {bmi}");


            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Je BMI is {bmi} je hebt {Bmi.ondergewicht}.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Je BMI is {bmi} je hebt {Bmi.normaalGewicht}.");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Je BMI is {bmi} je {Bmi.overgewicht}. Je loopt niet echt een risico, maar je mag niet dikker worden.");
            }
            else if (bmi >= 30 && bmi < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Je BMI is {bmi}, {Bmi.Zwaarlijvigheid} (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
            }
            else if (bmi >= 40)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Je BMI is {bmi}, {Bmi.ernstigeZwaarlijvigheid}. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");
            }
        }
    }
}
