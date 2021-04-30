using System;
using System.Collections.Generic;

namespace EenEigenHuis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kamer> huis = new List<Kamer>();

            int keuze = 0;
            do
            {
                Console.WriteLine("Maak je keuze: 1 gang toeveogen, 2 salon toeveogen, 3 badkamer toeveogen, ander cijfer stoppen");
                keuze = Convert.ToInt32(Console.ReadLine());

                if (keuze == 1)
                {
                    Gang gang = new Gang();
                    huis.Add(gang);
                }
                else if (keuze == 2)
                {
                    Salon salon = new Salon();
                    huis.Add(salon);
                }
                else if (keuze == 3)
                {
                    Badkamer badkamer = new Badkamer();
                    huis.Add(badkamer);
                }
            } while (keuze == 1 || keuze == 2 || keuze == 3);

            foreach (Kamer kamer in huis)
            {
                Console.WriteLine($"{kamer.Prijs}");
            }
        }
    }
}
