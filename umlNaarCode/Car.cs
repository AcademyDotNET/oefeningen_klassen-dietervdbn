using System;
using System.Collections.Generic;
using System.Text;

namespace umlNaarCode
{
    class Car
    {
        private Wheel[] wielen = new Wheel[4];
        public Engine Motor
        {
            get { return Motor; }
            set { Motor = value; }
        }
        public void MaakWielenAan(Wheel[] wielen)
        {
            for (int i =0; i < wielen.Length; i++)
            {
                wielen[i] = new Wheel();
            }
        }
    }
}
