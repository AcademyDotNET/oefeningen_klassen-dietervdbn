using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class RockDestroyer : MapElements, IDestroyer, IMoveable
    {
        public RockDestroyer(char drawChar) : base(drawChar)
        {

        }
        Random rand = new Random();
        public static void UpdatemRockDestroyers(List<RockDestroyer> RockDestroyers, int lengte, int breedte)
        {
            Random rand = new Random();
            int richting = 0;
            foreach (var rockDestroyer in RockDestroyers)
            {
                richting = rand.Next(1, 5);
                switch (richting)
                {
                    case 1:
                        if (rockDestroyer.Location.X > 51)
                        {
                            Console.SetCursorPosition(rockDestroyer.Location.X, rockDestroyer.Location.Y);
                            Console.Write(' ');
                            rockDestroyer.MoveLeft();
                            rockDestroyer.Draw();
                        }
                        break;
                    case 2:
                        if (rockDestroyer.Location.X < 49 + breedte)
                        {
                            Console.SetCursorPosition(rockDestroyer.Location.X, rockDestroyer.Location.Y);
                            Console.Write(' ');
                            rockDestroyer.MoveRight();
                            rockDestroyer.Draw();
                        }
                        break;
                    case 3:
                        if (rockDestroyer.Location.Y > 6)
                        {
                            Console.SetCursorPosition(rockDestroyer.Location.X, rockDestroyer.Location.Y);
                            Console.Write(' ');
                            rockDestroyer.MoveUp();
                            rockDestroyer.Draw();
                        }
                        break;
                    case 4:
                        if (rockDestroyer.Location.Y < 4 + lengte)
                        {
                            Console.SetCursorPosition(rockDestroyer.Location.X, rockDestroyer.Location.Y);
                            Console.Write(' ');
                            rockDestroyer.MoveDown();
                            rockDestroyer.Draw();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public List<MapElements> clearLeftRight(List<MapElements> AllElements, Player speler)
        {
            int index1 = -1;
            int index2 = -1;
            int teller = 0;
            foreach (var element in AllElements)
            {
                if (element is Rock)
                {
                    if ((Location.X == element.Location.X - 1) && (Location.Y == element.Location.Y))
                    {
                        index1 = teller;
                    }
                    if ((Location.X == element.Location.X + 1) && (Location.Y == element.Location.Y))
                    {
                        index2 = teller;
                    }
                }
                teller++;
            }
            if (!(index1 == -1))
            {
                AllElements.RemoveAt(index1);
            }
            if (!(index2 == -1))
            {
                AllElements.RemoveAt(index2);
            }
            if ((Location.X == speler.Location.X - 1) && (Location.Y == speler.Location.Y))
            {
                speler.lives -= 1;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine($"Rockdestroyers shot you down! {speler.lives} lives to go");
            }
            if ((Location.X == speler.Location.X + 1) && (Location.Y == speler.Location.Y))
            {
                speler.lives -= 1;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine($"Rockdestroyers shot you down! {speler.lives} lives to go");
            }
            teller++;
            return AllElements;

        }
        public override void Draw()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }

        public void Shoot()
        {
            Console.SetCursorPosition(Location.X + 1, Location.Y);
            Console.Write(' ');
        }

        public void MoveDown()
        {
            Location.Y += 1;
        }

        public void MoveLeft()
        {
            Location.X -= 1;
        }

        public void MoveRight()
        {
            Location.X += 1;
        }

        public void MoveUp()
        {
            Location.Y -= 1;
        }
    }
}
