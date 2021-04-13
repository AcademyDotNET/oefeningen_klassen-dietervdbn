using System;

namespace My_First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = FoodInput();
            string collor = CollorInput();
            string film = FilmInput();
            string car = CarInput();
            string book = BookInput();
            Console.WriteLine($"je favoriete kleur is (food). Je eet graag (car). Je lievelingsfilm is (book)en je favoriete boek is (collor)" );
        }
        public static string FoodInput()
        {
            Console.WriteLine("geef je lievelingsgerecht");
            string food = Console.ReadLine();
            return food;
        }
        public static string CollorInput()
        {
            Console.WriteLine("Wat is je favoriete kleur");
            string collor = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Green;
            return collor;
        }
        public static string FilmInput()
        {
            Console.WriteLine("Je favoriete film");
            string film = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Blue;
           return film;
        }
        public static string CarInput()
        {
            Console.WriteLine("Je favoriete auto");
            string car = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            return car;
        }
        public static string BookInput()
        {
            Console.WriteLine("Je favoriete boek");
            string book = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Cyan;
            return book;
        }
    }
}
