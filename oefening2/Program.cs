using System;
namespace Oefening2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hoeveel sliep je in september?");
            int september = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hoeveel sliep je in oktober?");
            int oktober = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hoeveel sliep je in november?");
            int november = Convert.ToInt32(Console.ReadLine());
            int resultaat = (september + oktober + november) / 3;
            Console.WriteLine($"het gemiddelde is {resultaat}");
        }

    }
}