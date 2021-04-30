using System;

namespace Moederbord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoeveel ram slots zijn er op je moederbord?");
            int AantalMRamSlots = Convert.ToInt32(Console.ReadLine());
            Moederbord moederbord = new Moederbord(AantalMRamSlots);
            Moederbord.VulRamSlotsOp(AantalMRamSlots, moederbord.ramGeheugen);
            moederbord.TestMoederbord(moederbord);
        }
    }
}
