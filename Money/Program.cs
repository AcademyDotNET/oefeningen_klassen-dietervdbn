using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            BankRekening rekening = new BankRekening(2500);
            SpaarRekening spaar = new SpaarRekening(2500);
            ProRekening pro = new ProRekening(2500);
            double rekeningR = rekening.BerekenRente(rekening);
            double spaarR = spaar.BerekenRente(spaar);
            double proR = pro.BerekenRente(pro);

            Console.WriteLine(rekeningR);
            Console.WriteLine(spaarR);
            Console.WriteLine(proR);
        }
    }
}
