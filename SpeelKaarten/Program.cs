using System;
using System.Collections.Generic;

namespace SpeelKaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kaart> kaartspel = new List<Kaart>();
            int teller = 0;
            for (int j = 0; j<4; j++)
            {
                Suite test = Suite.Harten;
                switch (j)
                { 
                    case 0:
                        test = Suite.Harten;
                        break;
                    case 1:
                        test = Suite.Klaveren;
                        break;
                    case 2:
                        test = Suite.Ruiten;
                        break;
                    case 3:
                        test = Suite.Schoppen;
                        break;
                }
                for (int i = 0; i < 13; i++)
                {
                    Kaart kaart = new Kaart((i+1), test);
                    kaartspel.Insert(teller, kaart);
                    //toon elke kaart:
                    //Console.WriteLine($"{kaartspel[teller].Kleur}, {kaartspel[teller].Waarde}");
                    teller++;
                }
            }

            trekEenKaart(kaartspel);
            trekEenKaart(kaartspel);
            trekEenKaart(kaartspel);
            trekEenKaart(kaartspel);
            trekEenKaart(kaartspel);
            trekEenKaart(kaartspel);
            trekEenKaart(kaartspel);
            trekEenKaart(kaartspel);
            trekEenKaart(kaartspel);
            ToonKaartspel(kaartspel);

        }
        public static void trekEenKaart(List<Kaart> kaartspel)
        {
            Random rand = new Random();
            int plaats = rand.Next(0, kaartspel.Count);
            Kaart kaart = kaartspel[plaats];
            kaartspel.RemoveAt(plaats);
        }
        public static void ToonKaartspel(List<Kaart> kaartspel)
        {
            for (int j = 0; j < kaartspel.Count; j++)
            {
                Console.WriteLine($"{kaartspel[j].Kleur}, {kaartspel[j].Waarde}");
            }
        }
    }
}
