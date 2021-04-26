using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BookmarkManager
{
    class HiddenBookmark : Bookmark
    {
        public HiddenBookmark(int nummer) : base(nummer)
        {


        }
        public override void Opensite(Bookmark bookmark)
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe ","-incognito " + bookmark.Url);
        }
        public override string? ToString()
        {
            
            return base.ToString() + ($" ---HIDDEN---)");
        }
    }
}
