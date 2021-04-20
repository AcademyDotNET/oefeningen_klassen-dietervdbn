using System;
using System.Collections.Generic;
using System.Text;

namespace SpeelKaarten
{
    public enum Suite { Schoppen, Harten, Klaveren, Ruiten };
    class Kaart
    {
        public Suite Kleur { get; set; }
        public Kaart(int waarde, Suite type)
        {
            Waarde = waarde;
            Kleur = type;
        }
        public Kaart()
        {

        }
        private int waarde = 0;
        public int Waarde
        {
            get
            {
                return waarde;
            }
            set
            {
                waarde = value;
            }
        }
    }
}
