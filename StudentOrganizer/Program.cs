using System;
using System.Collections.Generic;

namespace StudentOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel studenten wil je ingeven?");
            int totStudenten = Convert.ToInt32(Console.ReadLine());
            List<Student> studenten = new List<Student>();
            for (int i = 0; i < totStudenten; i++)
            {
                studenten.Add(new Student());
            }

            int keuze = 1;
            do
            {
                Console.WriteLine("Maak je keuze: 1 studenten aanpassen, 2 toon studenten, 3 zoek een student");
                keuze = Convert.ToInt32(Console.ReadLine());

                if (keuze == 1)
                {
                    Console.WriteLine("welke student wil je veranderen? geef nummer");
                    int keuzeStudent = Convert.ToInt32(Console.ReadLine());
                    keuzeStudent--;
                    studenten.RemoveAt(keuzeStudent);
                    studenten.Insert(keuzeStudent, new Student());
                }
                else if (keuze == 2)
                {
                    for (int i = 0; i < totStudenten; i++)
                    {
                        if (studenten[i] != null)
                        {
                            studenten[i].GeefOverzicht();
                            Console.WriteLine();
                        }
                    }
                }
                else if (keuze == 3)
                {
                    Console.WriteLine("wlke student zoek je?");
                    string naam = Console.ReadLine();
                    for (int i = 0; i < totStudenten; i++)
                    {
                        if (naam== studenten[i].Naam)
                        {
                            studenten[i].GeefOverzicht();
                        }
                    }
                }
            } while (keuze ==1 || keuze == 2 || keuze ==3);

        }
    }
}
