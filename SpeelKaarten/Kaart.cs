using System;
using System.Collections.Generic;
using System.Text;

namespace SpeelKaarten
{
    public enum Suite { Schoppen, Harten, Klaveren, Ruiten };
    class Kaart : IKaart
    {
        public Suite Kleur { get; set; }
        public Kaart(int waarde, Suite type)
        {
            Waarde = waarde;
            Kleur = type;
        }
        public Kaart()
        {

        }
        private int waarde = 0;
        public int Waarde
        {
            get
            {
                return waarde;
            }
            set
            {
                waarde = value;
            }
        }
        public bool CheckIfSame(Kaart kaart1, Kaart kaart2)
        {
            if (kaart1.waarde == kaart2.waarde)
            {
                if (kaart1.Kleur == kaart2.Kleur)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Stack<Kaart> SchufleDeck(List<Kaart> kaartspel)
        {
            Stack<Kaart> kaartspel2 = new Stack<Kaart>();
            Random rand = new Random();
            int plaats = rand.Next(0, kaartspel.Count + 1);
            int aantalKaarten = kaartspel.Count;
            for (int i = 0; i< aantalKaarten; i++)
            {
                Kaart trekKaart = TrekEenKaartUitList(kaartspel);
                kaartspel2.Push(trekKaart);
            }
            return kaartspel2;
        }
        public static Kaart TrekEenKaartUitList(List<Kaart> kaartspel)
        {
            Random rand = new Random();
            int plaats = rand.Next(0, kaartspel.Count);
            Kaart kaart = kaartspel[plaats];
            kaartspel.RemoveAt(plaats);
            return kaart;
        }
        public static Kaart TrekEenKaart(Stack<Kaart> kaartspel)
        {
            Kaart kaart = kaartspel.Pop();
            return kaart;
        }
        public static void ToonKaartspel(List<Kaart> kaartspel)
        {
            for (int j = 0; j < kaartspel.Count; j++)
            {
                Console.WriteLine($"{kaartspel[j].Kleur}, {kaartspel[j].Waarde}");
            }
        }
        public static void DeelDeKaarten(Stack<Kaart> kaartspel, Stack<Kaart> kaartenSpeler, Stack<Kaart> kaartenBank)
        {
            Kaart kaartSpeler1 = TrekEenKaart(kaartspel);
            kaartenSpeler.Push(kaartSpeler1);
            Kaart kaartSpeler2 = TrekEenKaart(kaartspel);
            kaartenSpeler.Push(kaartSpeler2);
            Kaart kaartBank1 = TrekEenKaart(kaartspel);
            kaartenBank.Push(kaartBank1);
            Kaart kaartBank2 = TrekEenKaart(kaartspel);
            kaartenBank.Push(kaartBank2);
            Console.WriteLine($"Speler: {kaartSpeler1}, {kaartSpeler2}");
            Console.WriteLine($"Casino: {kaartBank2}");
        }
        public static bool checkConditions(Stack<Kaart> kaartenSpeler, Stack<Kaart> kaartenBank)
        {
            if(kaartenSpeler.Count ==2)
            {
                if (GeefWaarde(kaartenSpeler) == 21)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Proficiat, blackjack");
                    Console.BackgroundColor = ConsoleColor.Black;
                    return true;
                }
            }            
            if (GeefWaarde(kaartenSpeler)<=21)
            {
                if (GeefWaarde(kaartenSpeler)> GeefWaarde(kaartenBank) || (GeefWaarde(kaartenBank) > 21))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Proficiat je wint");
                    Console.ForegroundColor = ConsoleColor.White;
                    return true;
                }
                else if (GeefWaarde(kaartenSpeler) == GeefWaarde(kaartenBank))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("push");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("De bank wint");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("busted");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }

        public static int GeefWaarde(Stack<Kaart> handKaarten)
        {
            bool bevat1 = false;
                foreach (var kaartje in handKaarten) 
            {
                if (kaartje.Waarde == 1)
                {
                    bevat1 = true;
                }
            }
            int totaal = 0;
            foreach(var kaart in handKaarten)
            {
                if (kaart.Waarde > 10)
                {
                    totaal += 10;
                }
                else
                {
                    totaal += kaart.Waarde;
                }
            }
            if (bevat1 == true)
            {
                if (totaal <= 11)
                {
                    totaal += 10;
                }
            }
            return totaal;
        }
        public override string ToString()
        {
            if (waarde == 1)
            {
                return ("A " + Kleur);
            }
            else if(waarde == 11)
            {
                return ("J " + Kleur);
            }
            else if(waarde == 12)
            {
                return ("D " + Kleur);
            }
            else if (waarde == 13)
            {
                return ("K " + Kleur);
            }
            else
            {
                return (waarde.ToString() + ' ' + Kleur);
            }
        }
        public string DrawCard(Kaart handKaarten)
        {
                return $@"
		┌─────────┐
		│{waarde}       │
		│         │
		│         │
		│    {Kleur}    │
		│         │
		│         │
		│       {waarde}│
		└─────────┘";
        }
        public static Stack<Kaart> ClearStack(Stack<Kaart> kaartspel)
        {
            int j = kaartspel.Count;
            for (int i =0; i<j;i++)
            {
                kaartspel.Pop();
            }
            return kaartspel;
        }
        public static double InzetBepaler(double kapitaal, double aantalKaarten, double aantalTienen)
        {
            //double aantalK = aantalKaarten;
            //double aantalT = aantalTienen;
            double deling = aantalKaarten / aantalTienen;
            double inzet = 0;
            if (deling < 2.5)
            {
                inzet = kapitaal *0.2;
            }
            else if (deling < 3)
            {
                inzet = kapitaal *0.1;
            }
            else if (deling < 3.5)
            {
                inzet = kapitaal *0.05;
            }
            else
            {
                inzet = kapitaal *0.025;
            }            
            return Math.Round(inzet);
        }
        public static double TelKaartenInDeck (Stack<Kaart> kaartspel)
        {
            double aantal = 0;
            foreach(var kaart in kaartspel)
            {
                aantal++;
            }
            return aantal;
        }
        public static double TelTienenInDeck(Stack<Kaart> kaartspel)
        {
            double aantal = 0;
            foreach (var kaart in kaartspel)
            {
                if (kaart.Waarde >= 10)
                {
                    aantal++;
                }
            }
            return aantal;
        }
    }
}
