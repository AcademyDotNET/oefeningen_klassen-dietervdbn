using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Rock : MapElements
    {
        public Rock(char drawChar) : base(drawChar)
        {

        }
        public override void Draw()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }
    }
}
