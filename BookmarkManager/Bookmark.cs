using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace BookmarkManager
{
    class Bookmark
    {
        public Bookmark(int nummer)
        {
            Console.WriteLine("wat is de naam van de website?");
            string naam = Console.ReadLine();
            Console.WriteLine("wat is de url?");
            string url = Console.ReadLine();
            Name = naam;
            Url = url;
            Nummer = nummer;
        }
        public string Name { get; set; }
        public string Url { get; set; }
        private int Nummer { get; set; }
        public static void ToonOverzicht (Bookmark[] websites)
        {
            for (int i = 0; i < websites.Length;i++) 
            {
                Console.WriteLine($"Website nr: {websites[i].Nummer}");
                Console.WriteLine($"{websites[i].Name}: {websites[i].Url}");
                Console.WriteLine();
            }            
        }
        public static void SiteKeuze(Bookmark[] websites, int nummer)
        {
            for (int i = 0; i < websites.Length; i++)
            {
                if (websites[i].Nummer == nummer)
                {
                    websites[i].Opensite(websites[i]);
                }
            }
        }
        public virtual void Opensite(Bookmark bookmark)
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", bookmark.Url);
        }
        public override string? ToString()
        {
            return ($"{Name} ({Url})");
        }
    }
}
