using System;

namespace muziekEnMethodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeelBroederJacob();
            SpeelYouAreMySunshine();

            /*Do(500, 1);
            Re(500, 1);
            Mi(500, 1);
            Fa(500, 1);
            Sol(500, 1);
            La(500, 1);
            Si(500,1);
            Do2(500,1);
            */
        }
        private static void SpeelBroederJacob()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("broe");
                Fa(500, 1);
                Console.Write("der ");
                Sol(500, 1);
                Console.Write("Ja");
                La(500, 1);
                Console.Write("cob ");
                Fa(500, 1);
            }
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Slaapt ");
                La(500, 1);
                Console.Write("gij ");
                Si(500, 1);
                Console.Write("nog? ");
                Do(750, 2);
            }
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Hoor ");
                Do(250, 2);
                Console.Write("de ");
                Re(250, 2);
                Console.Write("klo");
                Do(250, 2);
                Console.Write("ken ");
                Si(250, 1);
                Console.Write("lui");
                La(500, 1);
                Console.Write("den ");
                Fa(500, 1);
            }
            for (int j = 0; j < 2; j++)
            {
                Console.Write("bim ");
                Fa(500, 1);
                Console.Write("bam ");
                Do(500, 1);
                Console.Write("bom ");
                Fa(750, 1);
            }

        }

        private static void SpeelYouAreMySunshine()
        {
            Console.Write("you ");
            Re(500,1);
            Console.Write("are ");
            Sol(500, 1);
            Console.Write("my ");
            La(500, 1);
            Console.Write("sun");
            Si(750, 1);
            Console.Write("shine ");
            Si(750, 1);
            Console.Write("my ");
            Si(500, 1);
            Console.Write("on");
            La(500, 1);
            Console.Write("li ");
            Si(500, 1);
            Console.Write("sun");
            Sol(750, 1);
            Console.Write("shine ");
            Sol(750, 1);
            Console.Write("you ");
            Sol(500, 1);
            Console.Write("make ");
            La(500, 1);
            Console.Write("me ");
            Si(500, 1);
            Console.Write("ha");
            Do(750, 2);
            Console.Write("ppy ");
            Mi(750, 2);
            Console.Write("when ");
            Mi(500, 2);
            Console.Write("skies ");
            Re(500, 2);
            Console.Write("are ");
            Do(500, 1);
            Console.Write("grey ");
            Si(1000, 1);

            Console.Write("you/'ll ");
            Sol(500, 1);
            Console.Write("ne");
            La(500, 1);
            Console.Write("ver ");
            Si(500, 1);
            Console.Write("know ");
            Do(750, 1);
            Console.Write("dear ");
            Mi(1000, 2);
            Console.Write("how ");
            Mi(500, 1);
            Console.Write("much ");
            Re(500, 1);
            Console.Write("I ");
            Do(500, 1);
            Console.Write("love ");
            Si(750, 1);
            Console.Write("you ");
            Sol(750, 1);

        }

        private static void Do2(int noot , int octaaf)
        {
           // Console.WriteLine("Do");
            Console.Beep((528*octaaf), noot);
        }

        private static void Si(int noot, int octaaf)
        {
            //Console.WriteLine("Si");
            Console.Beep((495 * octaaf), noot);
        }

        private static void La(int noot, int octaaf)
        {
            //Console.WriteLine("La");
            Console.Beep((440 * octaaf), noot);
        }

        private static void Sol(int noot, int octaaf)
        {
            //Console.WriteLine("sol");
            Console.Beep((396 * octaaf), noot);
        }

        private static void Fa(int noot, int octaaf)
        {
            //Console.WriteLine("Fa");
            Console.Beep((352 * octaaf), noot);
        }

        private static void Mi(int noot, int octaaf)
        {
            //Console.WriteLine("Mi");
            Console.Beep((330 * octaaf), noot);
        }

        private static void Re(int noot, int octaaf)
        {
            //Console.WriteLine("Re");
            Console.Beep((297 * octaaf), noot);
        }

        private static void Do(int noot, int octaaf)
        {
            //Console.WriteLine("Do");
            Console.Beep((264 * octaaf), noot);
        }
    }
}
