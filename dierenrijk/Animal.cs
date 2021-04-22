using System;
using System.Collections.Generic;
using System.Text;

namespace dierenrijk
{
    class Animal
    {
        public bool BeweegVoort { get; set; }

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
    }
}
