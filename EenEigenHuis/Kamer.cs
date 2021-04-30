using System;
using System.Collections.Generic;
using System.Text;

namespace EenEigenHuis
{
    class Kamer
    {
        protected int oppervlakte { get; set; }
        protected bool schouw { get; set; }
        private int prijs = 400;
        public int Prijs
        {
            get
            {
                return prijs;
            }
            set
            {
                prijs = value;
            }
        }
        private string Naam { get; set; }
    }
}
