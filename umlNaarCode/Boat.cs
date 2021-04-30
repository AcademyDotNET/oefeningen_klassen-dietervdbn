using System;
using System.Collections.Generic;
using System.Text;

namespace umlNaarCode
{
    class Boat
    {
        public Boat()
        {
            Console.WriteLine("hoeveel propellors bevat de boot?");
            aantalprop = Convert.ToInt32(Console.ReadLine());
        }
        public static int aantalprop { get; set; }
        private Propeller[] Propellers = new Propeller[aantalprop];
        public Crankshaft crankshaft
        {
            get { return crankshaft; }
            set { crankshaft = value; }
        }
        public void MaakPropellorsAan(Propeller[] Propellers)
        {
            for (int i = 0; i < Propellers.Length; i++)
            {
                Propellers[i] = new Propeller();
            }
        }
        public Engine Motor
        {
            get { return Motor; }
            set { Motor = value; }
        }

    }
}
