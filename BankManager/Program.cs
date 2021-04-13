using System;

namespace BankManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Account dieter = new Account();
            dieter.StelIn("Dieter Vanderbemden", 1000, 54697534215342);

            Account jesse = new Account();
            jesse.StelIn("Jesse Viskens", 1000, 54697534215342);

            dieter.WithdrawFunds(dieter.Bedrag);
            dieter.PayInFunds(dieter.Bedrag);
            dieter.GetBalance(dieter.Bedrag);
            

        }
    }
}
