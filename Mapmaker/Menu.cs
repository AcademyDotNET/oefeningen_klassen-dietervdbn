using System;
using System.Collections.Generic;
using System.Text;

namespace Mapmaker
{
    class Menu
    {
        public Menu()
        { }

        public void ShowMenu()
        {
            //Tekenen
            TekenBalk(1);
            TekenOpties(2);
            TekenBalk(7);
        }
        private void TekenBalk(int hoogte)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, hoogte);
                Console.Write('*');
            }
        }
        private void TekenOpties(int hoogte)
        {
            Console.SetCursorPosition(5, hoogte);
            Console.Write("A) teken muren");
            Console.SetCursorPosition(5, hoogte + 1);
            Console.Write("B) Tafel toevoegen");
            Console.SetCursorPosition(5, hoogte + 2);
            Console.Write("C) Toon alles");
            Console.SetCursorPosition(5, hoogte + 3);
            Console.Write("D) Verplaatsen naar onder");
            Console.SetCursorPosition(5, hoogte + 4);
            Console.Write("Q om te stoppen");
        }
    }
}
