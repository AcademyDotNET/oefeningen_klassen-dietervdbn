using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{
    class Patient
    {
        public Patient()
        {
            Console.WriteLine($"wat is de naam van de patient?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hoelang blijf {name} in het ziekenhuis?(in uren)");
            int hour = Convert.ToInt32(Console.ReadLine());
            HoursInHospital = hour;
            Name = name;
        }
        public string Name { get; set; }
        public int HoursInHospital { get; set; }

        public virtual int BerekenKost()
        {
            int totalKost = 0;
            totalKost = (HoursInHospital * 20) + 50;
            return totalKost;
        }
        public virtual void ToonInfo()
        {
            Console.WriteLine($"{Name} lag {HoursInHospital} uren in het ziekenhuis, zijn totale kost is: {BerekenKost()}");
        }
    }
}
