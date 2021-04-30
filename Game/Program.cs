using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            int lengte = 15;
            int breedte = 30;
            bool gewonnen = false;
            Battlefield battlefield = new Battlefield(lengte, breedte);
            battlefield.TekenSpeelveld();
            Player speler = new Player('X');
            speler.Draw();

            List<MapElements> AllElements = new List<MapElements>();
            Random rand = new Random();

            //Random monsters genereren            
            List<Monster> monsters = new List<Monster>();
            for (int i=0; i < 9; i++)
            {
                Monster monster = new Monster('M');
                monster.Location.X = rand.Next(51, breedte + 50);
                monster.Location.Y = rand.Next(6, lengte + 5);                
                AllElements.Add(monster);
            }

            //Random Rockdestroyers genereren            
            List<RockDestroyer> rockDestroyers = new List<RockDestroyer>();
            for (int i = 0; i < 2; i++)
            {
                RockDestroyer rockDestroyer = new RockDestroyer('D');
                rockDestroyer.Location.X = rand.Next(51, breedte + 50);
                rockDestroyer.Location.Y = rand.Next(6, lengte + 5);                
                AllElements.Add(rockDestroyer);
            }

            //Random Rocks genereren            
            List<Rock> stenen = new List<Rock>();
            for (int i = 0; i < 15; i++)
            {
                Rock steen = new Rock('O');
                steen.Location.X = rand.Next(51, breedte + 50);
                steen.Location.Y = rand.Next(6, lengte + 5);                
                AllElements.Add(steen);
            }

            foreach (var element in AllElements)
            {
                element.Draw();
            }

            updateElements(AllElements, monsters, rockDestroyers, stenen);
            char keuze = 'Z';
            //The game
            do
            {
                Console.SetCursorPosition(1,1);
                do
                {
                    Console.WriteLine("Wat wil je doen? L:left, R:right, U:up, D:down, S:shoot");
                    keuze = Convert.ToChar(Console.ReadLine());
                    keuze = char.ToUpper(keuze);
                } while (!(keuze == 'L')&& !(keuze == 'R') && !(keuze == 'U') && !(keuze == 'D') && !(keuze == 'S'));

                switch (keuze)
                {
                    case 'L':
                        Console.SetCursorPosition(speler.Location.X, speler.Location.Y);
                        Console.Write(' ');
                        speler.MoveLeft();
                        if (speler.CheckIfStoneFree(stenen))
                        {
                            speler.Draw();
                        }
                        else
                        {
                            speler.MoveRight();
                            speler.Draw();
                        }
                        break;
                    case 'R':
                        Console.SetCursorPosition(speler.Location.X, speler.Location.Y);
                        Console.Write(' ');
                        speler.MoveRight();
                        if (speler.CheckIfStoneFree(stenen))
                        {
                            speler.Draw();
                        }
                        else
                        {
                            speler.MoveLeft();
                            speler.Draw();
                        }
                        break;
                    case 'U':
                        Console.SetCursorPosition(speler.Location.X, speler.Location.Y);
                        Console.Write(' ');
                        speler.MoveUp();
                        if (speler.CheckIfStoneFree(stenen))
                        {
                            speler.Draw();
                        }
                        else
                        {
                            speler.MoveDown();
                            speler.Draw();
                        }
                        break;
                    case 'D':
                        Console.SetCursorPosition(speler.Location.X, speler.Location.Y);
                        Console.Write(' ');
                        speler.MoveDown();
                        if (speler.CheckIfStoneFree(stenen))
                        {
                            speler.Draw();
                        }
                        else
                        {
                            speler.MoveUp();
                            speler.Draw();
                        }
                        break;
                    case 'S':
                        speler.Shoot();
                        speler.CheckIfKill(AllElements);
                        updateElements(AllElements, monsters, rockDestroyers, stenen);
                        break;
                    default:
                        Console.WriteLine($"An unexpected value");
                        break;
                }
                
                if (speler.Location.X == 50 + breedte)
                {
                    gewonnen = true;
                    Console.SetCursorPosition(1,10);
                    Console.WriteLine("Gewonnen");
                    //Console.BackgroundColor = ConsoleColor.Green;
                }
                RockDestroyer.UpdatemRockDestroyers(rockDestroyers, lengte, breedte);                
                foreach(var rockdestroyer in rockDestroyers)
                {
                    AllElements = rockdestroyer.clearLeftRight(AllElements, speler);
                }
                Monster.UpdatemMonsters(monsters, lengte, breedte);
                if (speler.CheckForMonsters(monsters))
                {
                    speler.lives -= 1;
                    Console.SetCursorPosition(15, 2);

                    Console.WriteLine($"WASTED, monster ate you {speler.lives} lives to go");
                    //Console.BackgroundColor = ConsoleColor.Red;
                }               
                if (speler.lives <= 0)
                {
                    speler.Alive = false;
                }
            } while ((speler.Alive) && (gewonnen == false));
        }
        static void updateElements(List<MapElements> AllElements, List<Monster> monsters, List<RockDestroyer> rockDestroyers, List<Rock> stenen)
        {
            monsters.Clear();
            stenen.Clear();
            rockDestroyers.Clear();
            foreach (var element in AllElements)
            {
                if (element is Monster)
                {
                    monsters.Add((Monster)element);
                }
                if (element is Rock)
                {
                    stenen.Add((Rock)element);
                }
                if (element is RockDestroyer)
                {
                    rockDestroyers.Add((RockDestroyer)element);
                }
            }
        }
    }
}
