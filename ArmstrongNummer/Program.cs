using System;

namespace ArmstrongNummer
{
    class Program
    {
        static void Main(string[] args)
        {
            //ControleGetal();
            Console.WriteLine("Geef een getal in:");
            string getalInString = Console.ReadLine();
            int getal = Convert.ToInt32(getalInString);
            int initieelGetal = getal;
            

            int lengte = getalInString.Length;
            double supTotaal = 0;

            for (int i=0; i<lengte ; i++)
            {
                int getalTotMacht = getal %10;
                getal = (getal - getalTotMacht) / 10;
                supTotaal = (supTotaal + Math.Pow(getalTotMacht, lengte ));
            }

            if (initieelGetal == supTotaal)
            {
                Console.WriteLine("het is een armstrong getal:");
            }

            else
            {
                Console.WriteLine("het is geen armstrong getal:");
            }


            /*static int ControleGetal(getal)
            {
                do
                {
                    Console.WriteLine("Geef een getal in:");
                    int getal =Convert.ToInt32(Console.ReadLine());
                } while (getal <0 || getal > 100000);
                return getal;
            }*/
        }
    }
}
