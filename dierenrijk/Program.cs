using System;
using System.Collections.Generic;

namespace dierenrijk
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> dieren  = new List<Animal>();
            char keuze = 'T';
            do
                while (!(keuze == 'K') && !(keuze == 'S') && !(keuze == 'L') && !(keuze == 'H') && !(keuze == 'R'))
                {
                    Console.WriteLine("Welk dier wil je toevoegen?: K:koe S:slang L:leguaan H:hond R:rabbit, Q:quit");
                    keuze = Convert.ToChar(Console.ReadLine());
                }

            switch (keuze)
            {
                case 'K':
                    Console.WriteLine("Hoe noemt je koe?");
                    string naam = Console.ReadLine();
                    cow koe = new cow(naam);
                    dieren.Add(koe);
                    break;
                case 'S':
                    Console.WriteLine("Hoe noemt je slang?");
                    string naamS = Console.ReadLine();
                    Snake snake = new Snake(naamS);
                    dieren.Add(snake);
                    break;
                case 'L':
                    Console.WriteLine("Hoe noemt je leguaan?");
                    string naamL = Console.ReadLine();
                    Iguana leguaan = new Iguana(naamL);
                    dieren.Add(leguaan);
                    break;
                case 'H':
                    Console.WriteLine("Hoe noemt je hond?");
                    string naamH = Console.ReadLine();
                    dog dog = new dog(naamH);
                    dieren.Add(dog);
                    break;
                case 'R':
                    Console.WriteLine("Hoe noemt je koe?");
                    string naamR = Console.ReadLine();
                    Rabbit rabbit = new Rabbit(naamR);
                    dieren.Add(rabbit);
                    break;
                default:
                    Console.WriteLine($"An unexpected value");
                    break;
            }
            while (!(keuze == 'Q')) ;

            foreach (Animal dier in dieren)
            {
                dier.ToonInfo();
                Console.WriteLine();
            }
            foreach (Animal dier in dieren)
            {
                Console.WriteLine(dier.Zegt());
            }
        }
    }
}
