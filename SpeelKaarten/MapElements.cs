using System;
using System.Collections.Generic;
using System.Text;

namespace SpeelKaarten
{
    abstract class MapElements
    {
        public MapElements(char drawChar)
        {
            DrawChar = drawChar;
        }

        public Point Location { get; set; } = new Point(1, 1);
        public char DrawChar { get; set; } = 'O';
        public abstract void Draw();
    }
}
