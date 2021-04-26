using System;
using System.Collections.Generic;
using System.Text;

namespace Money
{
    abstract class Rekening
    {
        public Rekening(double saldo)
        {
            rekening = saldo;
        }
        private double rekening { get; set; }
        public double Account
        {
            get
            {
                return rekening;
            }
        }
        public static void VoegGeldToe(Rekening rek)
        {
            Console.WriteLine($"hoeveel geld wil je storten?");
            double storting = Convert.ToInt64(Console.ReadLine());
            rek.rekening += storting;
        }
        public static void HaalGeldAf(Rekening rek)
        {
            Console.WriteLine($"hoeveel geld wil je storten?");
            double afhaling = Convert.ToInt64(Console.ReadLine());
            rek.rekening -= afhaling;
        }
        public virtual double BerekenRente(Rekening rek)
        {
            double rente =rek.rekening * 1.05;
            return rente;
        }
        public override string? ToString()
        {

            return ($"{rekening}");
        }
        public static bool Equals(Rekening rekA, Rekening rekB)
        {
            if (rekA.rekening == rekB.rekening)
                return true;
            return false;
        }
    }
}