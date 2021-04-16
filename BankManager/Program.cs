using System;

namespace BankManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Account dieter = new Account();
            dieter.StelIn("Dieter Vanderbemden", 1000, 54697534215342);

            Account spaarRekening = new Account();
            spaarRekening.StelIn("Jesse Viskens", 1000, 54697534215342);

            dieter.WithdrawFunds(dieter.Bedrag);
            dieter.PayInFunds(dieter.Bedrag);
            dieter.GetBalance(dieter.Bedrag);

            Sparen(dieter, spaarRekening);
            Account.MaakNieuweKlantAan();
        }

        private static void Sparen(Account dieter, Account spaarRekening)
        {
            Console.WriteLine("hoeveel wil je overzetten naar je spaarrekening?");
            double spaar = Convert.ToDouble(Console.ReadLine());
            dieter.Bedrag -= spaar;
            spaarRekening.Bedrag += spaar;
        }
    }
}
