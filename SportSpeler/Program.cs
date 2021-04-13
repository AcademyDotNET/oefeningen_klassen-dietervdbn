using System;

namespace SportSpeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Speler courtois = new Speler();
            courtois.StelIn("Thibaut Courtois", 1, "Real Madrid",1.99, Posities.GK, false);

            Speler deBruyne = new Speler();
            deBruyne.StelIn("Kevin De Bruyne", 7, "Manchester city", 1.81, Posities.CAM, false);

            Speler alderweireld = new Speler();
            alderweireld.StelIn("Toby Alderweireld", 2,"Tottenham", 1.87, Posities.CB, false);

            Speler denayer = new Speler();
            denayer.StelIn("Jason Denayer", 3,"Lyon", 1.84, Posities.CB, false);

            Speler vertonghen = new Speler();
            vertonghen.StelIn("Jan Vertonghen", 4,"Tottenham", 1.89, Posities.LB, false);

            Speler dendoncker = new Speler();
            dendoncker.StelIn("Leander Dendoncker", 5,"Wolverhampton", 1.88, Posities.CDM, false);

            Speler tielemans = new Speler();
            tielemans.StelIn("Youri Tielemans", 6,"Monaco", 1.76, Posities.CB, false);

            tielemans.MaakTransfer(tielemans.Naam,tielemans.Club);
            Console.WriteLine($"{tielemans.Naam} speelt nu voor {tielemans.Club}.");

        }
    }
}
