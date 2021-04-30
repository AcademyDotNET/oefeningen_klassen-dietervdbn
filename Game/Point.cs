using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Point
    {
        public Point(int inx, int iny)
        {
            x = inx;
            y = iny;
        }
        private int x = 1;
        private int y = 1;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
