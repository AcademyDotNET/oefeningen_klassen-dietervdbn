using System;
using System.Collections.Generic;
using System.Text;

namespace Meetlat_constructor
{
    class Meetlat
    {
        public Meetlat(double beginLengte)
        {
            Lengte = beginLengte;
        }
        public Meetlat()
        {

        }
        private double lengte = 0;
        public double Lengte
        {
            private get
            {
                return lengte;
            }
            set
            {
                lengte = value;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"De ingegeven lengte is {Lengte} m:");
            Console.WriteLine($"\t * CM = {Lengte * 100}");
            Console.WriteLine($"\t * Km = {Lengte / 1000}");            
            Console.WriteLine($"\t * Feet = {Lengte * 3.2808}");
        }
    }
}
