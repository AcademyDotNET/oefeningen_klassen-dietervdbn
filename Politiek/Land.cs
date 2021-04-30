using System;
using System.Collections.Generic;
using System.Text;

namespace Politiek
{
    class Land
    {
        private Minister[] Regering = new Minister[4];
        private Minister EersteMinister { get; set; }
        private President PresidentLand { get; set; }
        private string Naam { get; set; }
        public Land()
        {
            Console.WriteLine("hoeveel ministers zijn er in dit land?");
            AantalMinisters = Convert.ToInt32(Console.ReadLine());
        }
        public static int AantalMinisters { get; set; }
        private Minister[] MinistersLans = new Minister[AantalMinisters];
        public void MaakMinistersAan(Minister[] Ministers)
        {
            for (int i = 0; i < Ministers.Length; i++)
            {
                Ministers[i] = new Minister();
                Regering[i] = Ministers[i];
            }
        }
        public void MaakRegering(President president, Minister[] Ministers)
        {
            if (this.PresidentLand == null)
            {
                EersteMinister = Ministers[0];
                for (int i = 1; i < Ministers.Length; i++)
                {
                    Ministers[i] = new Minister();
                    Regering[i] = Ministers[i];
                }
                PresidentLand = president;
            }
            else
                Console.WriteLine("er is al een regering");
        }        
    }
}
