using System;

namespace KleurcodeWeerstandNaarOhm
{
    enum Kleurcodes { zwart, bruin, rood, oranje, geel, groen, blauw, paars, grijs, wit}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wat is de kleur van de eerste ring?");
            string ringOne = Console.ReadLine();
            Type.GetType(ringOne);
            Kleurcodes numberOne ;

            Console.WriteLine("wat is de kleur van de tweede ring?");
            string ringTwo = Console.ReadLine();
            Type.GetType(ringTwo);
            Kleurcodes numberTwo;

            Console.WriteLine("wat is de kleur van de derde ring?");
            string ringTree = Console.ReadLine();
            Type.GetType(ringTree);
            Kleurcodes numberTree;

            switch (ringOne)
            {
                case "zwart":
                    numberOne = Kleurcodes.zwart;
            break;

                case "bruin":
                    numberOne = Kleurcodes.bruin;
            break;

                case "rood":
                    numberOne = Kleurcodes.rood;
            break;

                case "oranje":
                    numberOne = Kleurcodes.oranje;
            break;

                case "geel":
                    numberOne = Kleurcodes.geel;
            break;

                case "groen":
                    numberOne = Kleurcodes.groen;
            break;

                case "blauw":
                    numberOne = Kleurcodes.blauw;
            break;

                case "paars":
                    numberOne = Kleurcodes.paars;
            break;

                case "grijs":
                    numberOne = Kleurcodes.grijs;
            break;

                case "wit":
                    numberOne = Kleurcodes.wit;
            break;

                default:
                    numberOne = Kleurcodes.zwart;
                    Console.WriteLine($"Foutive ingave");
            break;

            }
            switch (ringTwo)
            {
                case "zwart":
                    numberTwo = Kleurcodes.zwart;
                    break;

                case "bruin":
                    numberTwo = Kleurcodes.bruin;
                    break;

                case "rood":
                    numberTwo = Kleurcodes.rood;
                    break;

                case "oranje":
                    numberTwo = Kleurcodes.oranje;
                    break;

                case "geel":
                    numberTwo = Kleurcodes.geel;
                    break;

                case "groen":
                    numberTwo = Kleurcodes.groen;
                    break;

                case "blauw":
                    numberTwo = Kleurcodes.blauw;
                    break;

                case "paars":
                    numberTwo = Kleurcodes.paars;
                    break;

                case "grijs":
                    numberTwo = Kleurcodes.grijs;
                    break;

                case "wit":
                    numberTwo = Kleurcodes.wit;
                    break;

                default:
                    numberTwo = Kleurcodes.zwart;
                    Console.WriteLine($"Foutive ingave");
                    break;

            }
            switch (ringTree)
            {
                case "zwart":
                    numberTree = Kleurcodes.zwart;
                    break;

                case "bruin":
                    numberTree = Kleurcodes.bruin;
                    break;

                case "rood":
                    numberTree = Kleurcodes.rood;
                    break;

                case "oranje":
                    numberTree = Kleurcodes.oranje;
                    break;

                case "geel":
                    numberTree = Kleurcodes.geel;
                    break;

                case "groen":
                    numberTree = Kleurcodes.groen;
                    break;

                case "blauw":
                    numberTree = Kleurcodes.blauw;
                    break;

                case "paars":
                    numberTree = Kleurcodes.paars;
                    break;

                case "grijs":
                    numberTree = Kleurcodes.grijs;
                    break;

                case "wit":
                    numberTree = Kleurcodes.wit;
                    break;

                default:
                    Console.WriteLine($"Foutive ingave");
                    numberTree = Kleurcodes.zwart;
                    break;

            }

            double code1 = System.Convert.ToDouble(numberOne);
            double code2 = System.Convert.ToDouble(numberTwo);
            double code3 = System.Convert.ToDouble(numberTree);

             code1 = code1 * 10;
             code3 = Math.Pow(10, code3);
             double result = (code1 + code2) * code3;

            Console.WriteLine($"Deze weerstand heeft een waarde van{result} Ohm?");
        }
    }
}
