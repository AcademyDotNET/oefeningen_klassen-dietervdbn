using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    abstract class Animal
    {
        public Animal(string naam)
        {
            Name = naam;
        }
        public bool BeweegVoort { get; set; }
        public string Name { get; set; }

        public virtual void ToonInfo()
        {
            if (BeweegVoort)
            {
                Console.WriteLine($"Dit dier kan zich verplaatsen");
            }
            else 
            {
                Console.WriteLine($"Dit dier kan zich niet verplaatsen");
            }
        }
        public abstract string Zegt();
    }
}
