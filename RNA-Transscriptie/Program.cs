using System;

namespace RNA_Transscriptie
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lijst = new char[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("geef een karacter in:");
                char teken = Convert.ToChar(Console.ReadLine());
                switch (teken)
                {
                    case 'G':
                        teken = 'C';
                        break;
                    case 'C':
                        teken = 'G';
                        break;
                    case 'T':
                        teken = 'A';
                        break;
                    case 'A':
                        teken = 'U';
                        break;
                    default:
                        break;
                }
                lijst[i] = teken;
                Console.WriteLine($"De letter wordt: {lijst[i]} ");
            }
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{lijst[j]}");
            }
        }
    }
}
