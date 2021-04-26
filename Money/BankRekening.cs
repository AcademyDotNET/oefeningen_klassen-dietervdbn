using System;
using System.Collections.Generic;
using System.Text;

namespace Money
{
    class BankRekening : Rekening
    {
        public BankRekening(double saldo) : base(saldo)
        {
        }
        public override double BerekenRente(Rekening rek)
        {
            double rente = 0;
            if (rek.Account >100)
            {
                rente = rek.Account * 1.05;
            }            
            return rente;
        }
    }
}
