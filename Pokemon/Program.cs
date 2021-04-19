using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonCard bulbasaur = new PokemonCard(45, 49, 49, 65, 65, 45) {Name = "Bulbasaur" };            

            PokemonCard charmander = new PokemonCard();

            PokemonCard pikachu = new PokemonCard() { HP_Base = 40, Name = "Pikachu" };

            bulbasaur.ShowInfo();
            LevelPokemon(bulbasaur);

            PokemonCard.Battle(bulbasaur, charmander);

            PokemonCard test = PokemonCard.GeneratorPokemon();
            PokemonCard testje = PokemonCard.GeneratorPokemon();

            PokemonCard.Battle(test, testje);

            static void LevelPokemon(PokemonCard poke)
            {
                Console.WriteLine($@"hoeveel keer wil je levellen?");
                int amount = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < amount; i++)
                {
                    poke.LevelUp();
                }
            }
            PokemonCard.ListOffPokemons();
            PokemonCard.Info();
        }
    }
}
