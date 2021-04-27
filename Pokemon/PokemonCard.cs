using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class PokemonCard
    {
        public PokemonCard()
        {
            HP_Base = 10;
            Attack_Base = 10;
            Defense_Base = 10;
            SpecialAttack_Base = 10;
            SpecialDefense_Base = 10;
            Speed_Base = 10;
        }
        public PokemonCard(int hp, int att, int def, int spAtt, int spDef, int speed)
        {
            HP_Base = hp;
            Attack_Base = att;
            Defense_Base = def;
            SpecialAttack_Base = spAtt;
            SpecialDefense_Base = spDef;
            Speed_Base = speed;
        }
        private static int amountLevelsUp;
        private static int amountBattles;
        private static int amountOffDraws;
        private static int amountOffNewPokemons;
        public static int AmountLevelsUp 
        {
            get
            {
                return amountLevelsUp;
            }
            set
            {
                amountLevelsUp = value;
            }
        }
        public static int AmountBattles
        {
            get
            {
                return amountBattles;
            }
            set
            {
                amountBattles = value;
            }
        }
        public static int AmountOffDraws
        {
            get
            {
                return amountOffDraws;
            }
            set
            {
                amountOffDraws = value;
            }
        }
        public static int AmountOffNewPokemons
        {
            get
            {
                return amountOffNewPokemons;
            }
            set
            {
                amountOffNewPokemons = value;
            }
        }
        private int hitPoints;
        private int AttackPoints;
        private int DefPoints;
        private int SpecialAttack;
        private int SpecialDefense;
        private int Speed;
        private int level = 1;
        private bool noLevelingAllowed = false;
        public bool NoLevelingAllowed
        {
            get
            {
                return noLevelingAllowed;
            }
            set
            {
                noLevelingAllowed = value;
            }
        }
        public int HP_Base
        {
            get
            {
                return hitPoints;
            }
            set
            {
                hitPoints = value;
            }
        }
        public int Attack_Base
        {
            get
            {
                return AttackPoints;
            }
            set
            {
                AttackPoints = value;
            }
        }
        public int Defense_Base
        {
            get
            {
                return DefPoints;
            }
            set
            {
                DefPoints = value;
            }
        }
        public int SpecialAttack_Base
        {
            get
            {
                return SpecialAttack;
            }
            set
            {
                SpecialAttack = value;
            }
        }
        public int SpecialDefense_Base
        {
            get
            {
                return SpecialDefense;
            }
            set
            {
                SpecialDefense = value;
            }
        }
        public int Speed_Base
        {
            get
            {
                return Speed;
            }
            set
            {
                Speed = value;
            }
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }
        public int Level
        {
            get
            {
                return level;
            }
            private set
            {
                level = value;
            }
        }
        public int Average
        {
            get
            {
                return ((HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base) / 6);
            }
        }
        public int Total
        {
            get
            {
                return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base);
            }
        }
        public int HP_Full
        {
            get
            {
                return ((((HP_Base + 50) * Level) / 50) + 10);
            }
        }
        public int Attack_Full
        {
            get
            {
                return (((Attack_Base * Level) / 50) + 5);
            }
        }
        public int Defense_Full
        {
            get
            {
                return (((Defense_Base * Level) / 50) + 5);
            }
        }
        public int SpecialAttack_Full
        {
            get
            {
                return (((SpecialAttack_Base * Level) / 50) + 5);
            }
        }
        public int SpecialDefens_Full
        {
            get
            {
                return (((SpecialDefense_Base * Level) / 50) + 5);
            }
        }
        public int Speed_Full
        {
            get
            {
                return (((Speed_Base * Level) / 50) + 5);
            }
        }
        public void LevelUp()
        {
            if (NoLevelingAllowed == true)
            {
                Console.WriteLine($"Leveling is not allowed for this pokemon");
            }
            else
            {
                level++;
                AmountLevelsUp++;
                ShowInfo();
            }
        }
        public void CreatePokemon(string name, int nummer, int hp, int attack, int def, int spAtt, int spDef, int speed)
        {
            Name = name;
            Number = nummer;
            HP_Base = hp;
            Attack_Base = attack;
            Defense_Base = def;
            SpecialAttack_Base = spAtt;
            SpecialDefense_Base = spDef;
            Speed_Base = speed;
            Level = 1;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} (level {Level})");
            Console.WriteLine($"Base stats:");
            Console.WriteLine($"\t * Health = {HP_Base}");
            Console.WriteLine($"\t * Speed = {Speed_Base}");
            Console.WriteLine($"\t * Attack = {Attack_Base}");
            Console.WriteLine($"\t * Defense = {Defense_Base}");
            Console.WriteLine($"\t * SpecialAttack = {SpecialAttack_Base}");
            Console.WriteLine($"\t * SpecialDefens = {SpecialDefense_Base}");
            Console.WriteLine($"Full stats:");
            Console.WriteLine($"\t * Health = {HP_Full}");
            Console.WriteLine($"\t * Speed = {Speed_Full}");
            Console.WriteLine($"\t * Attack = {Attack_Full}");
            Console.WriteLine($"\t * Defense = {Defense_Full}");
            Console.WriteLine($"\t * SpecialAttack = {SpecialAttack_Full}");
            Console.WriteLine($"\t * SpecialDefens = {SpecialDefens_Full}");
        }
        public static void Info()
        {
            Console.WriteLine($"Battle fought: \t \t {AmountBattles}");
            Console.WriteLine($"Amound of draws: \t {AmountOffDraws}");
            Console.WriteLine($"Amound of new pokemons:  {AmountOffNewPokemons}");
            Console.WriteLine($"Amound of levels up:\t {AmountLevelsUp}");
        }
        public static PokemonCard GeneratorPokemon()
        {
            AmountOffNewPokemons++;
            PokemonCard newPokemon = new PokemonCard();
            Random rand = new Random();
            Console.WriteLine("wat is de naam van de pokemon?");
            newPokemon.Name = Console.ReadLine();
            newPokemon.HP_Base = rand.Next(10, 51);
            newPokemon.Attack_Base = rand.Next(1, 21);
            newPokemon.Defense_Base = rand.Next(1, 21);
            newPokemon.SpecialAttack_Base = rand.Next(1, 21);
            newPokemon.SpecialDefense_Base = rand.Next(1, 21);
            newPokemon.Speed_Base = rand.Next(1, 21);
            return newPokemon;
        }
        public static PokemonCard [] ListOffPokemons()
        {
            Console.WriteLine("hoeveel pokemons wil je genereren?");
            int amount = Convert.ToInt32(Console.ReadLine());
            PokemonCard [] newPokemon = new PokemonCard [amount];
            for (int i =0; i < amount; i++)
            {
                newPokemon[i] = GeneratorPokemon();
            }
            return newPokemon;
        }

        public override string? ToString()
        {
            return($"{Name} {Level} {HP_Base} {Speed_Base} {Attack_Base} {Defense_Base} {SpecialAttack_Base} {SpecialDefense_Base} {HP_Full} {Speed_Full} {Attack_Full} {Defense_Full} {SpecialAttack_Full} {SpecialDefens_Full}");
        }
        public static int Battle(PokemonCard poke1, PokemonCard poke2)
        {
            int result = 0;
            AmountBattles++;
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
                int healthPoke1 = poke1.HP_Full - (poke2.Attack_Full - poke1.Defense_Full);
                int healthPoke2 = poke2.HP_Full - (poke1.Attack_Full - poke2.Defense_Full);

                if (healthPoke1 > healthPoke2)
                {
                    Console.WriteLine($"{poke1.Name} wint van {poke2.Name}");
                    poke1.LevelUp();
                }
                else if (healthPoke1 < healthPoke2)
                {
                    Console.WriteLine($"{poke2.Name} wint van {poke1.Name}");
                    poke2.LevelUp();
                }
                else
                {
                    AmountOffDraws++;
                    Console.WriteLine($"Gelijkspel");
                }
            }
            return result;
        }
        public override bool Equals(Object poke1)
        {
            PokemonCard poke2=(PokemonCard)poke1;
            if (Level == poke2.Level)
            {
                if (Name == poke2.Name)
                {
                    if (HP_Base == poke2.HP_Base)
                    {
                        if (Speed_Base == poke2.Speed_Base)
                        {
                            if (Attack_Base == poke2.Attack_Base)
                            {
                                if (Defense_Base == poke2.Defense_Base)
                                {
                                    if (SpecialAttack_Base == poke2.SpecialAttack_Base)
                                    { 
                                        if (SpecialDefense_Base == poke2.SpecialDefense_Base)
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
