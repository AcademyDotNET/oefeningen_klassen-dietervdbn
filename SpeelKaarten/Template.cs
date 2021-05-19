using System;
using System.Collections.Generic;
using System.Text;

namespace SpeelKaarten
{
    class Template
    {
        public Template(int leng, int breed)
        {
            Lengte = leng;
            Breedte = breed;
        }
        public Template(Stack<Kaart> kaartspel)
        {
        }
        private int lengte = 8;
        private int breedte = 11;
        public int Lengte
        {
            get
            {
                return lengte;
            }
            set
            {
                lengte = value;
            }
        }
        public int Breedte
        {
            get
            {
                return breedte;
            }
            set
            {
                breedte = value;
            }
        }
        public char hor = '_';
        public char vert = '|';
        public char Horizontaal
        {
            get
            {
                return hor;
            }
            set
            {
                hor = value;
            }
        }

        public char Vertikaal
        {
            get
            {
                return vert;
            }
            set
            {
                vert = value;
            }
        }
        public void TekenSpeelKaart(Point startpunt)
        {
            for (int i = startpunt.X; i < Breedte + startpunt.X; i++)
            {
                Console.SetCursorPosition(i + 1, startpunt.Y);
                Console.Write(Horizontaal);
            }
            for (int i = startpunt.Y; i < Lengte + startpunt.Y; i++)
            {
                Console.SetCursorPosition(Breedte + startpunt.X, i + 1);
                Console.Write(Vertikaal);
            }
            for (int i = startpunt.X; i < Breedte + startpunt.X; i++)
            {
                Console.SetCursorPosition(i, Lengte + startpunt.Y);
                Console.Write(Horizontaal);
            }
            for (int i = startpunt.Y; i < Lengte + startpunt.Y; i++)
            {
                Console.SetCursorPosition(startpunt.X, i + 1);
                Console.Write(Vertikaal);
            }
            Console.WriteLine();
        }
        public void TekenWaarde(Point startpunt, string tekst)
        {
            Console.SetCursorPosition(startpunt.X, startpunt.Y);
            Console.Write(tekst);
        }
        public void TekenVeld(Stack<Kaart> kaartspel, bool splerOfBank)
        {
            Point startPuntBank = new Point(50, 1);
            Point startPuntSpeler = new Point(50, 13);
            if (splerOfBank)
            {
                foreach (var kaart in kaartspel)
                {
                    TekenSpeelKaart(startPuntBank);
                    startPuntBank.X += 15;
                }
            }
            else
            {
                foreach (var kaart in kaartspel)
                {
                    TekenSpeelKaart(startPuntSpeler);
                    startPuntSpeler.X += 15;
                }
            }
        }
        public string GetValueToString(Kaart kaart)
        {
            string tekst = "";
            if (kaart.Waarde == 1)
            {
                tekst = "A";
            }
            else if (kaart.Waarde == 11)
            {
                tekst = "J";
            }
            else if (kaart.Waarde == 12)
            {
                tekst = "D";
            }
            else if (kaart.Waarde == 13)
            {
                tekst = "K";
            }
            else
            {
                tekst = kaart.Waarde.ToString();
            }
            return (tekst+ " ");
            ;
        }
        public string GetSuite(Kaart kaart)
        {
            string tekst = "";
            if (kaart.Kleur == SpeelKaarten.Suite.Harten)
            {
                tekst = "♥";
            }
            else if (kaart.Kleur == SpeelKaarten.Suite.Schoppen)
            {
                tekst = "♠";
            }
            else if (kaart.Kleur == SpeelKaarten.Suite.Klaveren)
            {
                tekst = "♣";
            }
            else if (kaart.Kleur == SpeelKaarten.Suite.Ruiten)
            {
                tekst = "♦";
            }
            return tekst;
            ;
        }

        public void TekenInhoud(Stack<Kaart> kaartspel, bool splerOfBank)
        {
            Point startPuntBank = new Point(54, 3);
            Point startPuntSpeler = new Point(54, 15);
            if (splerOfBank)
            {
                foreach (var kaart in kaartspel)
                {
                    string tekst = GetValueToString(kaart);
                    TekenWaarde(startPuntBank, tekst);
                    startPuntBank.Y += 2;
                    startPuntBank.X += 2;
                    string kleur = GetSuite(kaart);
                    TekenWaarde(startPuntBank, kleur);
                    startPuntBank.Y += 2;
                    startPuntBank.X += 2;
                    TekenWaarde(startPuntBank, tekst);
                    startPuntBank.Y -= 4;
                    startPuntBank.X += 11;
                }
            }
            else
            {
                foreach (var kaartje in kaartspel)
                {
                    string tekst = GetValueToString(kaartje);
                    TekenWaarde(startPuntSpeler, tekst);
                    startPuntSpeler.Y += 2;
                    startPuntSpeler.X += 2;
                    string kleur = GetSuite(kaartje);
                    TekenWaarde(startPuntSpeler, kleur);
                    startPuntSpeler.Y += 2;
                    startPuntSpeler.X += 2;
                    TekenWaarde(startPuntSpeler, tekst);
                    startPuntSpeler.Y -= 4;
                    startPuntSpeler.X += 11;
                }
            }
        }
        public void FirstCardBank(Kaart kaart)
        {
            Point startPuntBank = new Point(54, 3);

            string tekst = GetValueToString(kaart);
            TekenWaarde(startPuntBank, tekst);
            startPuntBank.Y += 2;
            startPuntBank.X += 2;
            string kleur = GetSuite(kaart);
            TekenWaarde(startPuntBank, kleur);
            startPuntBank.Y += 2;
            startPuntBank.X += 2;
            TekenWaarde(startPuntBank, tekst);

        }
    }
}

