using System;

namespace BookmarkManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //vraag 5 favoriete sites
            HiddenBookmark[] websites = new HiddenBookmark[1];
            int nummer = 1;
            for (int i = 0; i < websites.Length; i++)
            {
                HiddenBookmark site = new HiddenBookmark(nummer);
                websites[i] = site;
                nummer++;
            }
            HiddenBookmark.ToonOverzicht(websites);
            Console.WriteLine("maak u keuze");
            int keuze = Convert.ToInt32(Console.ReadLine());
            HiddenBookmark.SiteKeuze(websites, keuze);
            
        }
    }
}
