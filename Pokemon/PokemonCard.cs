using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class PokemonCard
    {
        private int hitPoints;
        private int AttackPoints;
        private int DefPoints;
        private int SpecialAttack;
        private int SpecialDefense;
        private int Speed;
        private int level = 1;
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
                level++;
                ShowInfo();
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
    }
}
