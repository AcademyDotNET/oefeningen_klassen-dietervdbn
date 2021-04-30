using System;
using System.Collections.Generic;
using System.Text;

namespace Moederbord
{
    class Moederbord
    {
        public Moederbord(int ramslots)
        {
            Console.WriteLine("Wat is de naam van je moederbord?");
            Naam = Console.ReadLine();
            Console.WriteLine("Van welk merk is je moederbord?");
            Merk = Console.ReadLine();
            AantalMRam = ramslots;
            ramGeheugen = new Ram[AantalMRam];
        }
        private int AantalUsbPoorten { get; set; }
        private string Merk { get; set; }
        private string Naam { get; set; }
        private bool HasCoolingPaste { get; set; }
        private bool HasHdmiOutput { get; set; }
        private Baterrij Battery = new Baterrij();
        private Bios bios = new Bios();
        public static int AantalMRam { get; set; }
        public Ram[] ramGeheugen;
        public static void VulRamSlotsOp(int aantal, Ram[] ramSlots)
        {
            for (int i = 0; i < aantal; i++)
            {
                ramSlots[i] = new Ram();
            }
        }
        public void TestMoederbord(Moederbord moederbord)
        {
            if(moederbord.Battery == null)
            {
                Console.WriteLine("er is nog geen batterij aanwezig.");
            }
            if (moederbord.bios == null)
            {
                Console.WriteLine("er is nog geen bios geinstaleerd.");
            }
            if (moederbord.HasCoolingPaste = false)
            {
                Console.WriteLine("er is nog geen coolpasta aanwezig.");
            }
            if (!(moederbord.Battery == null) && !(moederbord.bios == null) && !(moederbord.HasCoolingPaste = false))
            {
                Console.WriteLine($"Dit is een moederbord van het merk {Merk}");
                Console.WriteLine($"Het ramgeheugen bestaat uit:");
                for (int k = 0; k < AantalMRam; k++)
                {
                    Console.WriteLine($"{ramGeheugen[k].TypeR}, {ramGeheugen[k].Groodte}GB");
                }                
                Console.WriteLine($"Het moederbord bevat {AantalUsbPoorten} Usb poorten");
                if (HasHdmiOutput)
                Console.WriteLine($"Er is een HDMI aansluitingen");
            } 
        }
    }
}
