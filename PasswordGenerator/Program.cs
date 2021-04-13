using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"wat is je famillienaam?");
            string familieNaam = Console.ReadLine();

            Console.WriteLine($"wat is je telefoon nummer?");
            int telefoon = Convert.ToInt32(Console.ReadLine());
            int telNummer = ReverseInteger(telefoon);

            Console.WriteLine($"wat is je postcode?");
            int postcodeVol = Convert.ToInt32(Console.ReadLine());
            int postcode = ReverseInteger(postcodeVol);

            char[] password = generatePassw(familieNaam, telNummer, postcode);
            toonWachtWoord(password);
        }

        private static void toonWachtWoord(char[] password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                Console.Write($"{password[i]}");
            }
        }

        public static int ReverseInteger(int start)
        {
            var reverse = string.Join("", Math.Abs(start).ToString().Reverse());
            return int.Parse(reverse) * Math.Sign(start);
        }

        private static char[] generatePassw(string familieNaam, int telNummer, int postcode)
        {
            char[] wachtwoord = new char[6];
            string letter1 = familieNaam.Substring(0, 1);
            char char1 = Convert.ToChar(letter1);
            string letter2 = familieNaam.Substring(1, 1);
            char char2 = Convert.ToChar(letter2);
            int charcode1 = (int)char1;
            int charcode2 = (int)char2;
            //eerste 2 letters van de naam
            if(charcode1>90)
            {
                charcode1 = charcode1 - 32;
            }
            if (charcode2 < 90)
            {
                charcode2 = charcode2 + 32;
            }
            wachtwoord[0] = (char)charcode2;
            wachtwoord[1] = (char)charcode1;

            // 2cijfers van telefoon nummer
            int telNummer1 = (telNummer%100);
            telNummer = (telNummer - telNummer1) / 100;
            int telNummer2 = (telNummer % 10);
            char test = (char)telNummer1;
            Console.WriteLine($"{test}");

            wachtwoord[2] = Convert.ToChar(telNummer1);
            wachtwoord[3] = Convert.ToChar(telNummer2);

            //eerste cijfer van postcode
            int postcode1 = (postcode % 10);
            postcode1 *= postcode1;
            int post1 = (postcode1 % 10);
            int post2 = (postcode1 - post1) / 10;

            wachtwoord[4] = Convert.ToChar(post2);
            wachtwoord[5] = Convert.ToChar(post1);

            return wachtwoord;
        }
    }
}
