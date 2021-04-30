using System;
using System.Collections.Generic;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> deck = new List<Card>();
            for (int i = 0;i<20; i++)
            {
                LandCard land = new LandCard();
                land.type = LandTypes.Blue;
                deck.Add(land);
            }
            for (int i = 0; i < 10; i++)
            {
                CreatureCard beast = new CreatureCard();
                Console.WriteLine("wat is de health van de creature?");
                int health = Convert.ToInt32(Console.ReadLine());
                beast.health = health;
                Console.WriteLine("wat is de attack van de creature?");
                int attack = Convert.ToInt32(Console.ReadLine());
                beast.attack = attack;
                deck.Add(beast);                
            }
            for (int i = 0; i < 5; i++)
            {
                SpellCard spell = new SpellCard();
                deck.Add(spell);
            }
        }
    }
}
