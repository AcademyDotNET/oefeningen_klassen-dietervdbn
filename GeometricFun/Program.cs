using System;

namespace GeometricFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de graden van de hoek?");
            double graden = Convert.ToDouble(Console.ReadLine());

            double radialen = (Math.PI * graden)/180;

            double sinus = Math.Sin(radialen);
            sinus = Math.Round((sinus * 180) / Math.PI, 2);

            double cosinus = Math.Cos(radialen);
            cosinus = Math.Round((cosinus * 180) / Math.PI,2);

            double tangens = Math.Tan(radialen);
            tangens = Math.Round((tangens * 180) / Math.PI, 2);

            Console.WriteLine($"de sinus van de hoek is {sinus}°");
            Console.WriteLine($"de cosinus van de hoek is {cosinus}°");
            Console.WriteLine($"de tangens van de hoek is {tangens}°");

        }
    }
}
