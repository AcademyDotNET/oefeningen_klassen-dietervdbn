using System;

namespace BookmarkManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //vraag 5 favoriete sites
            Bookmark[] websites = new Bookmark[5];
            int nummer = 1;
            for (int i = 0; i < websites.Length; i++)
            {
                Bookmark site = new Bookmark(nummer);
                websites[i] = site;
                nummer++;
            }
            Bookmark.ToonOverzicht(websites);
            Console.WriteLine("maak u keuze");
            int keuze = Convert.ToInt32(Console.ReadLine());
            Bookmark.SiteKeuze(websites, keuze);
            
        }
    }
}
