using System;
using System.Collections.Generic;
using System.Text;

namespace My_First_Project
{
    class firstClass
    {
        static void main(string[] args)
        {
            UserInput();
        }
        public static string UserInput() 
        {
            Console.WriteLine("geef uw neem");
            string name = Console.ReadLine();
            return name;
        }
    }
}
