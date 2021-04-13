using System;
using System.Collections.Generic;
using System.Text;

namespace BankManager
{
    class Account
    {
        public string Naam { get; set; }
        public double Bedrag { get; set; }
        public long RekeningNummer { get; set; }
        public void StelIn(string naam, double bedrag, long rekeningNummer)
        {
            Console.WriteLine($"{naam} heeft momenteel {bedrag} EUR op zijn rekening staan.");
            Naam = naam;
            Bedrag = bedrag;
            RekeningNummer = rekeningNummer;
        }
        public void WithdrawFunds(double bedrag)
        {
            Console.WriteLine("welk bedrag wil je afhalen?");
            double kosten = Convert.ToDouble(Console.ReadLine());
            if (kosten > bedrag)
            {
                Console.WriteLine($"Sorry, je hebt momenteel maar {bedrag} EUR op je rekening.");
            }
            else
            {
                bedrag -= kosten;
                Bedrag = bedrag;
            }
        }
        public void PayInFunds(double bedrag)
        {
            Console.WriteLine("welk bedrag wil je storten?");
            double kosten = Convert.ToDouble(Console.ReadLine());
            bedrag = bedrag + kosten;
            Bedrag = bedrag;
        }
        public void GetBalance(double bedrag)
        {
            Console.WriteLine($"Je totale balans is: {bedrag}");
        }        
    }
}
