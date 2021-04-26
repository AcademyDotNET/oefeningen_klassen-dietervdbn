using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book boekje = new Book();
            TextBook book = new TextBook();
            if (Book.Equals(boekje, book))
            {
                Console.WriteLine("De boeken zijn gelijk");
            } 
            else
            {
                Console.WriteLine("De boeken zijn niet gelijk");
            }
        }
    }
}
