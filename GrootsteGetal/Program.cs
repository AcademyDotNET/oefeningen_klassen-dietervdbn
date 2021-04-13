using System;

namespace GrootsteGetal
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int grootsteWaarde = 0;
            do
            {
                y = y + x;
                Console.WriteLine("Voer gehele waarden in (32767=stop)");
                string instring = Console.ReadLine();
                x = Convert.ToInt32(instring);
                if ((x > grootsteWaarde ) && (x != 32767))
                {
                    grootsteWaarde = x;
                }
            } while (x != 32767);
            Console.WriteLine($"Som is {y}");
            Console.WriteLine($"de grootste waarde is {grootsteWaarde}");
        }
    }
}
