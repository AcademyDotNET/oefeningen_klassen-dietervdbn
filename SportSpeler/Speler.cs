using System;
using System.Collections.Generic;
using System.Text;

namespace SportSpeler
{
    public enum Posities { GK, CB, LB, RB, LM, RM, CM, CDM, CAM, RW, LW, ST };
    class Speler
    {
        public string Naam { get; set; }
        public int Nummer { get; set; }
        public string Club { get; set; }
        public bool IsReserve { get; set; }
        public double Lengte { get; set; }



        public void StelIn(string naam, int nummer, string club ,double lengte, Posities plaats , bool isReserve)
        {       
            if (isReserve )
            {
                Console.WriteLine($"{naam} met het nummer {nummer} is {lengte} m. lang, speelt als {plaats} maar is geen basis-speler");
            }
                Console.WriteLine($"{naam} met het nummer {nummer} is {lengte} m. lang, speelt als {plaats}");
            Naam = naam;
            Nummer = nummer;
            Lengte = lengte;
            IsReserve = isReserve;
            Club = club;
        }
        public void MaakTransfer(string naam, string club)
        {
            Console.WriteLine($"{naam} maakt een transfer, hij vertrekt bij {club}. Naar welk team gaat hij nu?");
            string nieuweClub = Console.ReadLine();
            Club = nieuweClub;
        }

    }
}
