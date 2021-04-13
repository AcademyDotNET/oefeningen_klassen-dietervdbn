using System;

namespace RaadHetGetal
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int onderGrens = 0;
            int bovenGrens = 100;
            int poging = 0;
            int aantalPogingen = 0;
            int halvering = (bovenGrens- onderGrens);
            int maxAantalPogingen = 0;
            bool maxPogingen = false;
            string pogingString;
            bool gevonden = false;
            Random rand = new Random();
            getal = rand.Next(onderGrens, bovenGrens);

            while (!gevonden)
            {
                do
                {
                    Console.WriteLine($"Geef een getal tussen {onderGrens} en {bovenGrens}");
                    pogingString = Console.ReadLine();
                    poging = int.Parse(pogingString);
                } while (poging < onderGrens || poging > bovenGrens);
                aantalPogingen++;
                halvering = halvering / 2;
                if (halvering == 0)
                {
                    maxPogingen = true;
                }
                else 
                {
                    maxAantalPogingen++;
                }
                if (getal > poging)
                {
                    Console.WriteLine("Het gezochte getal is groter, probeer opnieuw.");
                }
                else if (getal < poging)
                {
                    Console.WriteLine("Het gezochte getal is kleiner, probeer opnieuw.");
                }
                else
                {
                    gevonden = true;
                }
            }
            if (maxPogingen == true)
            {
                Console.WriteLine($"je hebt {aantalPogingen} pogingen nodig gehad om het antwoord te vinden, de max pogingen waren {maxAantalPogingen}.");
            }
            else
            {
                Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
            }
        }
    }
}
