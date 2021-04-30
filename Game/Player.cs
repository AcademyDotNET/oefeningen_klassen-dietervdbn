using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Player : MapElements, IDestroyer, IMoveable
    {
        public Player(char drawChar) : base(drawChar)
        {
            drawChar = 'X';
            Location = new Point(50, 13);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }
        public int lives { get; set; } = 3;
        public bool Alive { get; set; } = true;

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

        public void Shoot()
        {
            Console.SetCursorPosition(Location.X+1, Location.Y);
            Console.Write(' ');
        }
        public bool CheckForMonsters(List<Monster> monsters)
        {
            bool clear = false;
            foreach(var monster in monsters)
            {
                if ((Location.X == monster.Location.X) && (Location.Y == monster.Location.Y))
                {
                    clear = true;
                }
            }
            return clear;
        }
        public void CheckIfKill(List<MapElements> AllElements)
        {
            int index = 0;
            int teller = 0;
            foreach (var Element in AllElements)
            {
                if ((Location.X == Element.Location.X-1) && (Location.Y == Element.Location.Y))
                {
                    index = teller;
                }
                teller++;
            }
            AllElements.RemoveAt(index);
        }

        public bool CheckIfStoneFree(List<Rock> stenen)
        {
            bool check = true;
            foreach (var steen in stenen)
            {
                if ((Location.X == steen.Location.X) && (Location.Y == steen.Location.Y))
                {
                    check = false;
                }
            }
            return check;
        }
    }
}
