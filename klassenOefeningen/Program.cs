using System;

namespace klassenOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Resultaat mijnpunten = new Resultaat();
            mijnpunten.Percentage = 65;
            mijnpunten.PrintGraad();

            Nummers paar1 = new Nummers();
            paar1.Getal1 = 50;
            paar1.Getal2 = 3;

            Console.WriteLine("Paar:" + paar1.Getal1 + ", " + paar1.Getal2);
            Console.WriteLine("Som = " + paar1.Som());
            Console.WriteLine("Verschil = " + paar1.Verschil());
            Console.WriteLine("Product = " + paar1.Product());
            Console.WriteLine("Quotient = " + paar1.Quotient());

            Studentklasse student1 = new Studentklasse();            
            Klas klassen = Klas.EA2;
            student1.Leeftijd = 21;
            student1.Naam = "Joske Vermeulen";
            student1.PuntenCommunicatie = 12;
            student1.PuntenProgrammingPrinciples = 15;
            student1.PuntenWebTech = 13;

            student1.GeefOverzicht();
            

            Pizza hawai = new Pizza();
            Console.WriteLine($"Ingave diameter");
            int diameter = IngaveInt();
            hawai.Diameter = diameter;
            Console.WriteLine($"Ingave toppings");
            string toppings = Console.ReadLine();
            hawai.Toppings = toppings;
            Console.WriteLine($"Ingave prijs");
            double prijs = IngaveDouble();
            hawai.Price = prijs;

        }

        private static int IngaveInt()
        {
            int diameter = 0;
            do
            {
                diameter = Convert.ToInt32(Console.ReadLine());
            } while (diameter <= 0);
            return diameter;
        }
        private static double IngaveDouble()
        {
            double prijs = 0;
            do
            {
                prijs = Convert.ToDouble(Console.ReadLine());
            } while (prijs <= 0);
            return prijs;
        }
    }
}
