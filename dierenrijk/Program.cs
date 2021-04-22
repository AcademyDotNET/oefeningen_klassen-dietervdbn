using System;
using System.Collections.Generic;

namespace dierenrijk
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            cow koe = new cow();
            Snake slang = new Snake();
            Iguana leguaan = new Iguana();
            List<Animal> dieren  = new List<Animal>();
            dieren.Add(animal);
            dieren.Add(slang);
            dieren.Add(koe);
            dieren.Add(leguaan);

            foreach (Animal dier in dieren)
            {
                dier.ToonInfo();
                Console.WriteLine();
            }

        }
    }
}
