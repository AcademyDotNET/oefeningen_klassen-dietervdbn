using System;

namespace OrakeltjeVanDelphi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genAge = new Random();
            int leeftijd = 0;
            Console.WriteLine("ben je een man of een vrouw(m,v)?");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("wat is je leeftijd?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (gender == 'm')
            {
                leeftijd = genAge.Next(age, 121);
            }
            else if (gender == 'v')
            {
                leeftijd = genAge.Next(age, 151);
            }
            else
            {
                Console.WriteLine("foute ingave.");
            }

            Console.WriteLine($"Je zal {leeftijd} jaar worden.");
        }
    }
}
