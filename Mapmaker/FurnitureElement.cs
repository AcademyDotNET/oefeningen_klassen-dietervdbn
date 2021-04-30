using System;
using System.Collections.Generic;
using System.Text;

namespace Mapmaker
{
    class FurnitureElement : MapObject
    {
        public FurnitureElement()
        {

        }
        public FurnitureElement(Point punt, int unitsize) : base (punt)
        {
            UnitSize = unitsize;
        }
        //public FurnitureElement(int x, int y) : base(x, y)
        //{

        //}
        //public FurnitureElement(int x, int y, int unitsize) : base(x, y)
        //{
        //    UnitSize = unitsize;
        //}
        //public FurnitureElement(int x, int y, char blok) : base(x, y, blok)
        //{

        //}
        public FurnitureElement(int x, int y, char blok, double prijs) : base(x, y, blok, prijs)
        {

        }
        public FurnitureElement(int x, int y, int unitsize, char blok, double prijs) : base(x, y, blok, prijs)
        {
            UnitSize = unitsize;
        }

        protected int unitSize;
        public int UnitSize
        {
            get { return unitSize; }
            set { if (value > 0) unitSize = value; }
        }

        public override void Paint()
        {
        }
    }
}
