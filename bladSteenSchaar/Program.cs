using System;

namespace bladSteenSchaar
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxOverwinningen = 2;
            int overwinningenGebruiker = 0;
            int overwinningenPc = 0;
            Random genNumber = new Random();

            do
            {
                Console.WriteLine("(1)blad, (2)steen, (3)schaar?");
                int guess = Convert.ToInt32(Console.ReadLine());
                int pcGuess = genNumber.Next(1, 3);

                switch (guess)
                {
                    case 1:
                        if (pcGuess == 2)
                        {
                            Console.WriteLine("punt voor de speler");
                            overwinningenGebruiker++;
                        }
                        else if (pcGuess == 3)
                        {
                            Console.WriteLine("punt voor de computer");
                            overwinningenPc++;
                        }
                        else
                        {
                            Console.WriteLine("gelijk");
                        }
                        break;
                    case 2:
                        if (pcGuess == 3)
                        {
                            Console.WriteLine("punt voor de speler");
                            overwinningenGebruiker++;
                        }
                        else if (pcGuess == 1)
                        {
                            Console.WriteLine("punt voor de computer");
                            overwinningenPc++;
                        }
                        else
                        {
                            Console.WriteLine("gelijk");
                        }
                        break;
                    case 3:
                        if (pcGuess == 1)
                        {
                            Console.WriteLine("punt voor de speler");
                            overwinningenGebruiker++;
                        }
                        else if (pcGuess == 2)
                        {
                            Console.WriteLine("punt voor de computer");
                            overwinningenPc++;
                        }
                        else
                        {
                            Console.WriteLine("gelijk");
                        }
                        break;
                }
            } while ((maxOverwinningen != overwinningenGebruiker) || (maxOverwinningen != overwinningenPc));
            if (overwinningenGebruiker > overwinningenPc)
            {
                Console.WriteLine("proficiat je bent gewonnen!");
            }
            else
            {
                Console.WriteLine("jammer, de computer is gewonnen");
            }
        }
    }
}
