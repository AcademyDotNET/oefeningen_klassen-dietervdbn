using System;

namespace FilmDefault
{
    class Program
    {
        public enum genre { drama, actie, thriller, commedy, documentary, unknown };
        static void Main(string[] args)
        {
            FilmRuntime("film", 6, genre.drama);
            FilmRuntime("nieuwe film zonder iets");
            FilmRuntime("film zonder genre", 70);
        }

        private static void FilmRuntime(string filmNaam, int duur = 90, genre g = genre.unknown)
        {
                        Console.WriteLine($"{filmNaam} ({duur}, {g})");
        }
    }
}
