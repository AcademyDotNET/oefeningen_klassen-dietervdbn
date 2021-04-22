using System;
using System.Collections.Generic;

namespace Balspel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WindowHeight = 20;
            Console.WindowWidth = 30;
            int ballenTegenMekaar = 0;
            int punten = 0;
            int timer = 0;
            PlayerBall player = new PlayerBall(10, 10, 0, 0);
            List<Ball> ballen = new List<Ball>();
            ballen.Add( new Ball(4, 4, 1, 0));
            ballen.Add( new Ball(4, 3, 0, 1));
            ballen.Add( new Ball(4, 2, 1, 1));
            ballen.Add( new Ball(4, 1, 1, 2));
            ballen.Add(new Ball(5, 3, 1, 0));
            ballen.Add(new Ball(2, 8, 1, 0));
            ballen.Add(new Ball(3, 2, 1, 0));
            ballen.Add(new Ball(4, 3, 0, 2));


            while (true)
            {

                Console.Clear();

                //Ball

                for (int i = 0; i < ballen.Count; i++)
                {
                    ballen[i].Update();
                    ballen[i].Draw();
                }

                //SpelerBall
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    player.ChangeVelocity(key);
                }

                player.Update();
                player.Draw();

                //Check collisions
                for (int j = 0; j < ballen.Count; j++)
                {
                    if (Ball.CheckHit(ballen[j], player))
                    {
                        Console.Clear();
                        punten += 1;
                        Console.WriteLine($"Gewonnen!");
                        Console.WriteLine($"je had {timer} seconden nodig");
                        Console.WriteLine($"je hebt nu {punten} punten");
                        Console.WriteLine();
                        Console.WriteLine($"Er waren in totaal {ballenTegenMekaar} ballen tegen mekaar gebotst");
                        ballenTegenMekaar = 0;
                        ballen.RemoveAt(j);
                        Console.ReadLine();
                    }
                }
                //Check collisions for balls
                foreach (Ball ball in ballen)
                {
                    for (int j = 0; j < ballen.Count; j++)
                    {
                        if (Ball.CheckHit(ballen[j], ball))
                        {
                            ballenTegenMekaar += 1;
                        }
                    }
                }
               

                System.Threading.Thread.Sleep(100);
                timer++;
            }
        }

    }
}
