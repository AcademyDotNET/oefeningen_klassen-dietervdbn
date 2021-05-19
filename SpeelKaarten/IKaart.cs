using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeelKaarten
{
    interface IKaart
    {
        public bool CheckIfSame(Kaart kaart1, Kaart kaart2);
        public Stack<Kaart> SchufleDeck(List<Kaart> kaartspel);

    }
}
