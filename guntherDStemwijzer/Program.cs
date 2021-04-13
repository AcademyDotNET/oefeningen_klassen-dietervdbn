using System;

namespace guntherDStemwijzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de gunther D stemwijzer!");
            Console.WriteLine("1ste vraag: werk jij veel?");
            char answerOne = Convert.ToChar(Console.ReadLine());

            switch (answerOne)
            {
                case 'J':
                    Console.WriteLine("koop je soms bruin brood?");
                    char answerTwo = Convert.ToChar(Console.ReadLine());

                    switch (answerTwo)
                    {
                        case 'J':
                            Console.WriteLine("Ben je een seut?");
                            char answerFour = Convert.ToChar(Console.ReadLine());

                            switch (answerFour)
                            {
                                case 'J':
                                    Console.WriteLine("Jij bent een echte CD&V'er");
                                    break;

                                case 'N':

                                    Console.WriteLine("Heb je vrienden?");
                                    char answerFive = Convert.ToChar(Console.ReadLine());

                                    switch (answerFive)
                                    {
                                        case 'J':

                                            Console.WriteLine("Staat de wagen of het huis waar je in woont op jou naam?");
                                            char answerSix = Convert.ToChar(Console.ReadLine());

                                            switch (answerSix)
                                            {
                                                case 'J':
                                                    Console.WriteLine("Jij stemt het beste voor open VLD");
                                                    break;

                                                case 'N':
                                                    Console.WriteLine("Politiek is niet zo jou ding dus stem maar blanco");
                                                    break;

                                                default:
                                                    Console.WriteLine("foute ingave!");
                                                    break;
                                            }
                                            break;

                                        case 'N':
                                            Console.WriteLine("Jou politieke voorkeur gaat uit naar NVA" );

                                            break;

                                        default:
                                            Console.WriteLine("foute ingave!");
                                            break;
                                    }
                                    break;

                                default:
                                    Console.WriteLine("foute ingave!");
                                    break;
                            }
                            break;

                        case 'N':
                            Console.WriteLine("Jij bent een echte vlaams belanger");
                            break;

                        default:
                            Console.WriteLine("foute ingave!");
                            break;
                    }
                    break;

                case 'N':
                    Console.WriteLine("eet je vaak Quinoa?");
                    char answerTree = Convert.ToChar(Console.ReadLine());

                    switch (answerTree)
                    {
                        case 'J':
                            Console.WriteLine("Je bent een echte natuurmens, stem op groen!");
                            break;

                        case 'N':
                            Console.WriteLine("Krijg je vaak de schuld voor alles?");
                            char answerSeven = Convert.ToChar(Console.ReadLine());

                            switch (answerSeven)
                            {
                                case 'J':
                                    Console.WriteLine("Je bent een echte socialist SPA (vooruit) is jou partij!");
                                    break;

                                case 'N':
                                    Console.WriteLine("geloof je nog is sinterklaas?");
                                    char answereight = Convert.ToChar(Console.ReadLine());

                                    switch (answereight)
                                    {
                                        case 'J':
                                            Console.WriteLine("PVDA!");
                                            break;

                                        case 'N':
                                            Console.WriteLine("Politiek is niet zo jou ding dus stem maar blanco?");
                                            break;

                                        default:
                                            Console.WriteLine("foute ingave!");
                                            break;
                                    }
                                    break;

                                default:
                                    Console.WriteLine("foute ingave!");
                                    break;
                            }
                            break;

                        default:
                            Console.WriteLine("foute ingave!");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("foute ingave!");
                    break;
            }
        }
    }
}
