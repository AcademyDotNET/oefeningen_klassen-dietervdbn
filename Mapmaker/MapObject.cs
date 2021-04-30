using System;
using System.Collections.Generic;
using System.Text;

namespace Mapmaker
{
    abstract class MapObject
    {
        public MapObject()
        {

        }
        public MapObject(Point punt)
        {
            Location = punt;
        }
        public MapObject(Point point, char blok, double prijs)
        {
            Location = point;
            DrawChar = blok;
            Price = prijs;
        }
        public MapObject(int x, int y, char blok, double prijs)
        {
            Point point = new Point(x, y);
            Location = point;
            DrawChar = blok;
            Price = prijs;
        }
        public Point Location { get; set; }

        protected double Price { get; set; }
        protected char drawChar = 'º';
        public char DrawChar
        {
            get
            {
                return drawChar;
            }
            private set
            {
                drawChar = value;
            }
        }
        public abstract void Paint();
    }
}
