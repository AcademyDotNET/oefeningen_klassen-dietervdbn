using System;
using System.Collections.Generic;
using System.Text;

namespace Politiek
{
    class President : Minister
    {
        private int Teller { get; set; }

        public void JaarVerder()
        {
            Teller++;
        }
    }
}
