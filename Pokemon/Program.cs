using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonCard bulbasaur = new PokemonCard();
            bulbasaur.CreatePokemon("Bulbasaur", 1, 45,49,49,65,65,45);

            PokemonCard charmander = new PokemonCard();
            charmander.CreatePokemon("Charmander", 4, 39, 52, 43, 60, 50, 65);

            bulbasaur.ShowInfo();
            LevelPokemon(bulbasaur);

            Battle(bulbasaur, charmander);


            static void LevelPokemon(PokemonCard poke)
            {
                Console.WriteLine($@"hoeveel keer wil je levellen?");
                int amount = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < amount; i++)
                {
                    poke.LevelUp();
                }
            }
            static int Battle(PokemonCard poke1, PokemonCard poke2)
            {
                int result = 0;
                if (poke1 == null)
                {
                    if (poke2 == null)
                    {
                        result = 0;
                        Console.WriteLine($"Bijde pokemons bestaan niet");
                    }
                    result = 2;
                    Console.WriteLine($"De eerste pokemon bestaat niet");
                }
                else if (poke2 == null)
                {
                    result = 1;
                    Console.WriteLine($"De 2de pokemon bestaat niet");
                }
                else
                {
                    int healthPoke1 = poke1.HP_Full -(poke2.Attack_Full - poke1.Defense_Full);
                    int healthPoke2 = poke2.HP_Full -(poke1.Attack_Full - poke2.Defense_Full);

                    if (healthPoke1 > healthPoke2)
                    {
                        Console.WriteLine($"{poke1.Name} wint van {poke2.Name}");
                        poke1.LevelUp();
                    }
                    else
                    {
                        Console.WriteLine($"{poke2.Name} wint van {poke1.Name}");
                        poke2.LevelUp();
                    }
                }
                return result;
            }
        }
    }
}
