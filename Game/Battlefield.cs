using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Battlefield
    {
        public Battlefield(int leng, int breed)
        {
            Lengte = leng;
            Breedte = breed;
        }
        private int lengte = 15;
        private int breedte = 30;
        public int Lengte
        {
            get
            {
                return lengte;
            }
            set
            {
                lengte = value;
            }
        }
        public int Breedte
        {
            get
            {
                return breedte;
            }
            set
            {
                breedte = value;
            }
        }
        public char hor = '_';
        public char vert ='|';
        public char Horizontaal
        {
            get
            {
                return hor;
            }
            set
            {
                hor = value;
            }
        }

        public char Vertikaal
        {
            get
            {
                return vert;
            }
            set
            {
                vert = value;
            }
        }
        public void TekenSpeelveld()
        {
            for (int i = 50; i < Breedte + 50; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write(Horizontaal);
            }
            for (int i = 5; i < Lengte + 5; i++)
            {
                Console.SetCursorPosition(Breedte + 50, i+1);
                Console.Write(Vertikaal);
            }
            for (int i = 50; i < Breedte + 50; i++)
            {
                Console.SetCursorPosition(i, Lengte + 5);
                Console.Write(Horizontaal);
            }
            for (int i = 5; i < Lengte + 5; i++)
            {
                Console.SetCursorPosition(50, i+1);
                Console.Write(Vertikaal);
            }
            Console.WriteLine();
        }
    }
}
