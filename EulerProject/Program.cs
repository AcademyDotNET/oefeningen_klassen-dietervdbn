using System;

namespace EulerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int getalBot = 0;
            int getalTop = 1001;
            int supTotaal = 0;


            for (int i = getalBot; i < getalTop; i++)
            {
                if ((i % 5) ==0)
                {
                    supTotaal += i;
                }
                else if ((i % 3)==0)
                {
                    supTotaal += i;
                }

            }
            Console.WriteLine($"het antwoord is:{supTotaal}");
        }
    }
}
