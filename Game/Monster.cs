using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Monster : MapElements, IMoveable
    {
        public Monster(char drawChar) : base(drawChar)
        {
            drawChar = 'O';
        }
        Random rand = new Random();
        public static void UpdatemMonsters(List<Monster> monsters, int lengte, int breedte)
        {
            Random rand = new Random();
            int richting = 0;
            foreach (var monster in monsters)
            {
                richting = rand.Next(1, 5);
                switch (richting)
                {
                    case 1:
                        if (monster.Location.X > 51)
                        {
                            Console.SetCursorPosition(monster.Location.X, monster.Location.Y);
                            Console.Write(' ');
                            monster.MoveLeft();
                            monster.Draw();
                        }
                        break;
                    case 2:
                        if (monster.Location.X < 49 + breedte)
                        {
                            Console.SetCursorPosition(monster.Location.X, monster.Location.Y);
                            Console.Write(' ');
                            monster.MoveRight();
                            monster.Draw();
                        }
                        break;
                    case 3:
                        if (monster.Location.Y > 6)
                        {
                            Console.SetCursorPosition(monster.Location.X, monster.Location.Y);
                            Console.Write(' ');
                            monster.MoveUp();
                            monster.Draw();
                        }
                        break;
                    case 4:
                        if (monster.Location.Y < 4 + lengte)
                        {
                            Console.SetCursorPosition(monster.Location.X, monster.Location.Y);
                            Console.Write(' ');
                            monster.MoveDown();
                            monster.Draw();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public override void Draw()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
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
