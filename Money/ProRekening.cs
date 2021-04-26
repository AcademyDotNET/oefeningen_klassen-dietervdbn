using System;
using System.Collections.Generic;
using System.Text;

namespace Money
{
    class ProRekening : SpaarRekening
    {
        public ProRekening(double saldo) : base(saldo)
        {
        }
        public override double BerekenRente(Rekening rek)
        {
            double rente = 0;
            rente = Math.Floor(rek.Account / 1000);
            rente += base.BerekenRente(rek);
                return rente;
        }
    }
}
