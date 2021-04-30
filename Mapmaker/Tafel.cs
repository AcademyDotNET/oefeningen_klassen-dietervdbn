using System;
using System.Collections.Generic;
using System.Text;

namespace Mapmaker
{
    class Tafel : FurnitureElement
    {
        public Tafel(Point punt, int unitsize) : base(punt, unitsize)
        {
            drawChar = 'T';
        }
        public Tafel(int x, int y, int unitsize, char blok, double prijs) : base(x, y, unitsize, blok, prijs)
        {

        }
        public override void Paint()
        {
            for (int i = Location.X; i < Location.X + UnitSize; i++)
            {
                for (int j = Location.Y; j < Location.Y + UnitSize+1; j++)
                {
                    if (i < Console.WindowWidth && j < Console.WindowHeight)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(DrawChar);
                    }
                }
            }
        }
    }
}
