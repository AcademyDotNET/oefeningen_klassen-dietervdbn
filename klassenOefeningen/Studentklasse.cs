using System;
using System.Collections.Generic;
using System.Text;

namespace klassenOefeningen
{
    public enum Klas { EA1, EB1, EA2, EB2, EA3, EB3, EA4, EB4, EA5, EB5, EA6, EB6 };
    class Studentklasse
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }
        public double BerekenTotaalCijfer(int PuntenCommunicatie, int PuntenProgrammingPrinciples, int PuntenWebTech)
        {
            double berekening = (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech)/3;
            return berekening;
        }
        public void GeefOverzicht()
        {
            double gemiddelde = BerekenTotaalCijfer(PuntenCommunicatie, PuntenProgrammingPrinciples, PuntenWebTech);
            Console.WriteLine($"{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas: {Klas.EA2}");
            Console.WriteLine($"");
            Console.WriteLine($"Cijferrapport::");
            Console.WriteLine($"**********");
            Console.WriteLine($"Communicatie: \t\t\t {PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles: \t {PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technology: \t\t {PuntenWebTech}");
            Console.WriteLine($"Gemiddelde: \t\t\t {gemiddelde}");
        }
    }
}
