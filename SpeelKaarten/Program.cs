using System;
using System.Collections.Generic;

namespace SpeelKaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            double kapitaal;
            Console.BufferWidth += 100;
            Console.WriteLine("Wat is je startkapitaal");
            while (!double.TryParse(Console.ReadLine(), out kapitaal))
            {
                Console.WriteLine("geef een getal");
            }
            Stack < Kaart > kaartenSpeler = new Stack<Kaart>();
            Stack<Kaart> kaartenBank = new Stack<Kaart>();

            //nieuw deck aanmaken
            List<Kaart> kaartspel = new List<Kaart>();
            int teller = 0;
            for (int j = 0; j < 4; j++)
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
                    Kaart kaart = new Kaart((i + 1), test);
                    kaartspel.Insert(teller, kaart);
                    teller++;
                }
            }

            Stack<Kaart> newDeck = new Stack<Kaart>();
            newDeck = Kaart.SchufleDeck(kaartspel);

            //black jack
            char keuze = 'Q';
            double inzet = -1;
            double waarde = 0;
            double waardebank = 0;
            string verder = "";

            while (!(verder == "STOP"))
            {
                inzet = Kaart.InzetBepaler(kapitaal, Kaart.TelKaartenInDeck(newDeck), Kaart.TelTienenInDeck(newDeck));
                Console.WriteLine($"inzet: {inzet}");

                Kaart.DeelDeKaarten(newDeck, kaartenSpeler, kaartenBank);
                Console.WriteLine($"je hebt nu: {Kaart.GeefWaarde(kaartenSpeler)}");
                Template speelVeld = new Template(kaartenBank);
                int temperaryPointX = Console.CursorLeft;
                int temperaryPointY = Console.CursorTop;
                speelVeld.TekenVeld(kaartenBank, true);
                speelVeld.TekenVeld(kaartenSpeler, false);
                speelVeld.FirstCardBank(kaartenBank.Peek());
                speelVeld.TekenInhoud(kaartenSpeler, false);
                Console.SetCursorPosition(temperaryPointX, temperaryPointY);

                do
                {

                    do
                    {
                        Console.WriteLine("X: nieuwe kaart, D: dubble down, C:pass");
                        while (!char.TryParse(Console.ReadLine(), out keuze))
                        {
                            Console.WriteLine("foute ingave, X: nieuwe kaart, D: dubble down, C:pass");
                        }         
                        keuze = char.ToUpper(keuze);
                    } while ((keuze != 'X') && (keuze != 'D') && (keuze != 'C'));

                    switch (keuze)
                    {
                        case 'X':
                            Kaart nieuwekaart = Kaart.TrekEenKaart(newDeck);
                            kaartenSpeler.Push(nieuwekaart);
                            Console.WriteLine($"{nieuwekaart} de waarde is nu {Kaart.GeefWaarde(kaartenSpeler)}");
                            temperaryPointX = Console.CursorLeft;
                            temperaryPointY = Console.CursorTop;
                            speelVeld.TekenVeld(kaartenSpeler, false);
                            speelVeld.TekenInhoud(kaartenSpeler, false);
                            Console.SetCursorPosition(temperaryPointX, temperaryPointY);
                            break;
                        case 'D':
                            Kaart nieuwekaartX = Kaart.TrekEenKaart(newDeck);
                            kaartenSpeler.Push(nieuwekaartX);
                            inzet += inzet;
                            Console.WriteLine($"{nieuwekaartX} de waarde is nu {Kaart.GeefWaarde(kaartenSpeler)}");
                            temperaryPointX = Console.CursorLeft;
                            temperaryPointY = Console.CursorTop;
                            speelVeld.TekenVeld(kaartenSpeler, false);
                            speelVeld.TekenInhoud(kaartenSpeler, false);
                            Console.SetCursorPosition(temperaryPointX, temperaryPointY);
                            break;
                        default:
                            break;
                    }
                    waarde = Kaart.GeefWaarde(kaartenSpeler);
                } while ((keuze != 'D') && (keuze != 'C') && (waarde <21));
                Console.WriteLine($"Casino zijn 2de kaart: {kaartenBank.Peek()}");
                temperaryPointX = Console.CursorLeft;
                temperaryPointY = Console.CursorTop;
                speelVeld.TekenInhoud(kaartenBank, true);
                Console.SetCursorPosition(temperaryPointX, temperaryPointY);
                Console.WriteLine($"het casino heeft: {Kaart.GeefWaarde(kaartenBank)}");
                waardebank = Kaart.GeefWaarde(kaartenBank);
                while (waardebank < 17)
                {
                    Kaart kaartje = Kaart.TrekEenKaart(newDeck);
                    Console.WriteLine($"volgende kaar voor het casino: {kaartje}");
                    kaartenBank.Push(kaartje);
                    temperaryPointX = Console.CursorLeft;
                    temperaryPointY = Console.CursorTop;
                    speelVeld.TekenVeld(kaartenBank, true);
                    speelVeld.TekenInhoud(kaartenBank, true);
                    Console.SetCursorPosition(temperaryPointX, temperaryPointY);
                    waardebank = Kaart.GeefWaarde(kaartenBank);
                };
                Console.WriteLine("");
                Console.WriteLine($"het casino heeft: {Kaart.GeefWaarde(kaartenBank)}");
                Console.WriteLine($"jij hebt: {Kaart.GeefWaarde(kaartenSpeler)}");
                if (Kaart.GeefWaarde(kaartenSpeler) != Kaart.GeefWaarde(kaartenBank))
                {
                    if (Kaart.checkConditions(kaartenSpeler, kaartenBank))
                    {
                        if (kaartenSpeler.Count == 2)
                        {
                            if (Kaart.GeefWaarde(kaartenSpeler) == 21)
                            {
                                kapitaal += (1.5 * inzet);
                                Console.Write($" je wint {(1.5 * inzet)} ");
                            }
                        }
                        else
                        {
                            kapitaal += inzet;
                            Console.Write($" je wint {(inzet)} ");
                        }
                    }
                    else
                    {
                        kapitaal -= inzet;
                        Console.Write($" je verliest {(inzet)} ");
                    }
                }
                kaartenSpeler = Kaart.ClearStack(kaartenSpeler);
                kaartenBank = Kaart.ClearStack(kaartenBank);
                Console.WriteLine($"Balans : {kapitaal}");
                Console.WriteLine("");
                Console.WriteLine("Wil je opnieuw spelen? STOP om te stoppen");
                verder =Console.ReadLine();
                verder = verder.ToUpper();
                Console.Clear();
            } 
        }
        //public char KeuzeInvoer ()
        //{
        //    char keuze = 'R';
        //    do
        //    {
        //        Console.WriteLine("X: nieuwe kaart, D: dubble down, C:pass");
        //        keuze = Convert.ToChar(Console.ReadLine());
        //        keuze = char.ToUpper(keuze);
        //    } while (!(keuze == 'X') && !(keuze == 'D') && !(keuze == 'C'));
        //    return keuze;
        //}
    }
}
