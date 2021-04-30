using System;
using System.Collections.Generic;
using System.Text;

namespace Mapmaker
{
    class WallElement : MapObject
    {
        public WallElement (Point point) : base(point)
        {

        }
        public WallElement(Point point, char blok, double prijs) : base(point, blok, prijs)
        {

        }

        //public WallElement(int x, int y) : base(x,y)
        //{

        //}
        //public WallElement(int x, int y, char blok) : base(x, y, blok)
        //{

        //}
        public WallElement(int x, int y,char blok, double prijs) : base(x, y, blok, prijs)
        {

        }
        public override void Paint()
        {
            //Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }
        public static WallElement[] MakeWallHorizontaal(int startX, int startY, int length)
        {
            Point point = new Point(startX, startY);
            WallElement[] wall = new WallElement[length];
            for (int i = 0; i<wall.Length;i++)
            {
                WallElement steen = new WallElement(point);
                wall[i] = steen;
                wall[i].Location = new Point(startX + i, startY);
            }
            return wall;
        }
        public static WallElement[] MakeWallHorizontaal(int startX, int startY, char blok, double prijs, int length)
        {
            Point point = new Point(startX, startY);
            WallElement[] wall = new WallElement[length];
            for (int i = 0; i < wall.Length; i++)
            {
                WallElement steen = new WallElement(point, blok, prijs);
                wall[i] = steen;
                wall[i].drawChar = blok;
                wall[i].Price = prijs;
                wall[i].Location = new Point(startX + i, startY);
            }
            return wall;
        }
        public static WallElement[] MakeWallVertikaal(int startX, int startY, int length)
        {
            Point point = new Point(startX, startY);
            WallElement[] wall = new WallElement[length];
            for (int i = 0; i < wall.Length; i++)
            {
                WallElement steen = new WallElement(point);
                wall[i] = steen;
                wall[i].Location = new Point(startX, startY+i);
            }
            return wall;
        }
        public static WallElement[] MakeWallVertikaal(int startX, int startY, char blok, double prijs, int length)
        {
            Point point = new Point(startX, startY);
            WallElement[] wall = new WallElement[length];
            for (int i = 0; i < wall.Length; i++)
            {
                WallElement steen = new WallElement(point, blok, prijs);
                wall[i] = steen;
                wall[i].drawChar = blok;
                wall[i].Price = prijs;
                wall[i].Location = new Point(startX, startY + i);
            }
            return wall;
        }
        public static void PaintAWall(WallElement[] wall)
        {
            for (int i = 0; i < wall.Length; i++)
            {
                wall[i].Paint();
            }
        }
        public static double BerekenMuurPrijs(WallElement[] wall)
        {
            double totaalkost = 0;
            foreach(var steen in wall)
            {
                totaalkost += steen.Price;
            }
            return totaalkost;
        }
    }  
}
