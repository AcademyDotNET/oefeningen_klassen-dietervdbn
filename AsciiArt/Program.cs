using System;

namespace AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hallo iedereen");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" mijn naam is:");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string myName = @"$$$$$$$\  $$\            $$\                         
$$  __$$\ \__ |           $$ |
$$ |  $$ |$$\  $$$$$$\ $$$$$$\    $$$$$$\   $$$$$$\  
$$ |  $$ |$$ |$$  __$$\\_$$  _ |  $$  __$$\ $$  __$$\ 
$$ |  $$ |$$ |$$$$$$$$ | $$ |    $$$$$$$$ |$$ |  \__ |
$$ |  $$ |$$ |$$   ____ | $$ |$$\ $$   ____ |$$ |
$$$$$$$  |$$ |\$$$$$$$\  \$$$$  |\$$$$$$$\ $$ |
\_______ / \__ | \_______ |  \____ /  \_______ |\__ |";
             Console.WriteLine(myName);
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
