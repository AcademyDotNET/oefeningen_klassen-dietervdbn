using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        public Book()
        {
            Console.WriteLine($"wat is de titel?");
            string titel = Console.ReadLine();
            Console.WriteLine($"auteur?");
            string auteur = Console.ReadLine();
            Console.WriteLine($"wat is het ISBN nummer?");
            int isbn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"wat is de prijs?");
            double prijs = Convert.ToInt64(Console.ReadLine());
            Price = prijs;
            Author = auteur;
            Title = titel;
            ISBN = isbn;
        }
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        private double price = 0;
        public virtual double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public static Book TelOp(Book book1, Book book2)
        {
            Book newBook = new Book();
            newBook.Title = ($"Omnibus van [{book1.Title}, {book2.Title}]");
            newBook.Price = (book1.Price + book2.Price) / 2;
            return newBook;
        }
        public override string? ToString()
        {
           
            return ($"{Title} - {Author}({ISBN}) {Price}");
        }

        public static bool Equals(Book objA, Book objB)
        {
            if (!(objA == null)||!(objB == null))
            {
                if (objA.ISBN == objB.ISBN)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }    
}
