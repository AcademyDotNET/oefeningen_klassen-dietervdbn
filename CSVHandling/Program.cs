using System;
using System.IO;

namespace CSVHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Net.WebClient wc = new System.Net.WebClient();
            string csv = wc.DownloadString("https://bit.ly/2tE4CB0");

            string[] splitted = csv.Split('\n');

            for (int i = 1; i < splitted.Length-1; i++)
            {
                
                string[] lijnsplit = splitted[i].Split(',');
                string type = lijnsplit[2];
                Console.WriteLine($"{lijnsplit[1]} \t number: {lijnsplit[0]}");
                switch (type)
                {
                    case "Grass":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"type1: {lijnsplit[2]} \t type2: {lijnsplit[3]}");
                        break;
                    case "Poison":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"type1: {lijnsplit[2]} \t type2: {lijnsplit[3]}");
                        break;
                    case "Fire":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine($"type1: {lijnsplit[2]} \t type2: {lijnsplit[3]}");
                        break;
                    case "Water":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"type1: {lijnsplit[2]} \t type2: {lijnsplit[3]}");
                        break;
                    case "Bug":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"type1: {lijnsplit[2]} \t type2: {lijnsplit[3]}");
                        break;
                    default:
                        Console.WriteLine($"type1: {lijnsplit[2]} \t type2: {lijnsplit[3]}");
                        break;

                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"\t stats:");
                Console.WriteLine($"\t * Total = {lijnsplit[4]}");
                Console.WriteLine($"\t * HP = {lijnsplit[5]}");
                Console.WriteLine($"\t * Attack = {lijnsplit[6]}");
                Console.WriteLine($"\t * Defense = {lijnsplit[7]}");
                Console.WriteLine($"\t * SpecialAttack = {lijnsplit[8]}");
                Console.WriteLine($"\t * SpecialDefens = {lijnsplit[9]}");
                Console.WriteLine($"\t * Speed = {lijnsplit[10]}");
                Console.WriteLine($"\t * Generation = {lijnsplit[11]}");
            }
            writeCsvStreamWriter(splitted);
            static void writeCsvStreamWriter(string[] splitted)
            {
                using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\vande\Documents\VDAB opleiding\pokemon.csv"))
                {
                    for (int i = 1; i < splitted.Length - 1; i++)
                    {                        
                        string[] lijnsplit = splitted[i].Split(',');
                        streamWriter.WriteLine($"{lijnsplit[1]} \t number: {lijnsplit[0]}");                         
                        streamWriter.WriteLine($"\t stats:");
                        streamWriter.WriteLine($"\t * Total = {lijnsplit[4]}");
                        streamWriter.WriteLine($"\t * HP = {lijnsplit[5]}");
                        streamWriter.WriteLine($"\t * Attack = {lijnsplit[6]}");
                        streamWriter.WriteLine($"\t * Defense = {lijnsplit[7]}");
                        streamWriter.WriteLine($"\t * SpecialAttack = {lijnsplit[8]}");
                        streamWriter.WriteLine($"\t * SpecialDefens = {lijnsplit[9]}");
                        streamWriter.WriteLine($"\t * Speed = {lijnsplit[10]}");
                        streamWriter.WriteLine($"\t * Generation = {lijnsplit[11]}");
                    }
                }
            }
            //CsvWriter.writeCsvNoStreamWriter();
            //CsvWriter.writeCsvStreamWriter();
        }
    }
}