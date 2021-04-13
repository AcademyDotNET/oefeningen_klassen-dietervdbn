using System;

namespace TafelsVanVermenigvuldigen
{
    class Program
    {
        static void Main(string[] args)
        {
            //int getal = ControleGetal (getal)
            GeefTafels();


            static void GeefTafels ()
            {
                for (int getal1 = 1; getal1 <=10; getal1++)
                {
                    for (int getal2 = 1; getal2 <=10; getal2++)
                    {
                        Console.WriteLine($"{getal1} * {getal2} = {getal1 * getal2}");
                    }
                }
            }

            /*static int ControleGetal(getal)
            {
                int getal =
                                Console.WriteLine("geef een getal?");
                int year = Convert.ToInt32(Console.ReadLine());
            }*/
        }
    }
}
