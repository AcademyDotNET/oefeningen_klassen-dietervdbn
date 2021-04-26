using System;
using System.Collections.Generic;
using System.Text;

namespace Money
{
    class SpaarRekening : Rekening
    {
        public SpaarRekening(double saldo) : base(saldo)
        {
        }
        public override double BerekenRente(Rekening rek)
        {
            double rente = rek.Account * 1.02;            
            return rente;
        }
    }
}
