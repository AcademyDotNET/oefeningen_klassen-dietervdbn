using System;
using System.Collections.Generic;
using System.Text;

namespace StudentOrganizer
{
    public enum Klas { EA1, EB1, EA2, EB2, EA3, EB3, EA4, EB4, EA5, EB5, EA6, EB6 };
    class Student
    {
        public Student()
        {
            Console.WriteLine("wat is je naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("wat is je leeftijd?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wat is je score voor communicatie?");
            int com = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wat is je score voor programming principles?");
            int prog = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wat is je score voor communicatie?");
            int web = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("in welke klas zit je?");
            string klas = Console.ReadLine();
            switch (klas)
            {
                case "EA1":
                    Klassen = Klas.EA1;
                    break;
                case "EB1":
                    Klassen = Klas.EB1;
                    break;
                case "EA2":
                    Klassen = Klas.EA2;
                    break;
                case "EB2":
                    Klassen = Klas.EB2;
                    break;
                case "EA3":
                    Klassen = Klas.EA3;
                    break;
                case "EB3":
                    Klassen = Klas.EB3;
                    break;
                case "EA4":
                    Klassen = Klas.EA4;
                    break;
                case "EB4":
                    Klassen = Klas.EB4;
                    break;
                case "EA5":
                    Klassen = Klas.EA5;
                    break;
                case "EB5":
                    Klassen = Klas.EB5;
                    break;
                case "EA6":
                    Klassen = Klas.EA6;
                    break;
                case "EB6":
                    Klassen = Klas.EB6;
                    break;

            }
            Naam = naam;
            Leeftijd = leeftijd;
            PuntenCommunicatie = com;
            PuntenProgrammingPrinciples = prog;
            PuntenWebTech = web;
        }
        private string naam = "joske";
        private int leeftijd = 0;
        private int puntenCommunicatie = 0;
        private int puntenProgrammingPrinciples = 0;
        private int puntenWebTech = 0;
        public string Naam
        {
            get
            {
                return naam;
            }
            set
            {
                naam = value;
            }
        }
        public int Leeftijd
        {
            get
            {
                return leeftijd;
            }
            set
            {
                leeftijd = value;
            }
        }
        public int PuntenCommunicatie
        {
            get
            {
                return puntenCommunicatie;
            }
            set
            {
                puntenCommunicatie = value;
            }
        }
        public int PuntenProgrammingPrinciples
        {
            get
            {
                return puntenProgrammingPrinciples;
            }
            set
            {
                puntenProgrammingPrinciples = value;
            }
        }
        public int PuntenWebTech
        {
            get
            {
                return puntenWebTech;
            }
            set
            {
                puntenWebTech = value;
            }
        }
        public Klas Klassen { get; set; }
        public double BerekenTotaalCijfer(int PuntenCommunicatie, int PuntenProgrammingPrinciples, int PuntenWebTech)
        {
            double berekening = (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3;
            return berekening;
        }
        public void GeefOverzicht()
        {
            double gemiddelde = BerekenTotaalCijfer(PuntenCommunicatie, PuntenProgrammingPrinciples, PuntenWebTech);
            Console.WriteLine($"{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas: {Klassen}");
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
