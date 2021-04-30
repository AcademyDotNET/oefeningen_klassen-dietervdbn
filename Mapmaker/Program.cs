using System;
using System.Collections.Generic;

namespace Mapmaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MapObject> allObjects = new List<MapObject>();
            List<WallElement[]> Muren = new List<WallElement[]>();
            char keuze = 'K';
            do
            {
                Menu menu = new Menu();
                menu.ShowMenu();

                keuze = Convert.ToChar(Console.ReadLine());
                keuze = char.ToUpper(keuze);
                
                Console.Clear();

                switch (keuze)
                {
                    case 'A':
                        Console.WriteLine("Hoelang moet je muur worden");
                        int lengte = Convert.ToInt32(Console.ReadLine());
                        WallElement[] muurNorth = new WallElement[lengte];
                        WallElement[] muurSouth = new WallElement[lengte];
                        WallElement[] muurWest = new WallElement[lengte];
                        WallElement[] muurEast = new WallElement[lengte];

                        muurNorth = WallElement.MakeWallHorizontaal(5, 10, lengte);
                        muurSouth = WallElement.MakeWallHorizontaal(5, 9 + lengte, lengte);
                        muurWest = WallElement.MakeWallVertikaal(5, 10, lengte);
                        muurEast = WallElement.MakeWallVertikaal(5 + lengte, 10, lengte);

                        Muren.Add(muurNorth);
                        Muren.Add(muurSouth);
                        Muren.Add(muurWest);
                        Muren.Add(muurEast);

                        WallElement.PaintAWall(muurNorth);
                        WallElement.PaintAWall(muurSouth);
                        WallElement.PaintAWall(muurWest);
                        WallElement.PaintAWall(muurEast);
                        break;
                    case 'B':
                        Console.WriteLine("Hoe groot moet je tafel worden");
                        int tafel = Convert.ToInt32(Console.ReadLine());
                        Point punt = new Point(9, 13);
                        Tafel nieuweTafel = new Tafel(punt, tafel);
                        allObjects.Add(nieuweTafel);
                        nieuweTafel.Paint();
                        break;
                    case 'C':
                        foreach (var muuur in Muren)
                        {
                            WallElement.PaintAWall(muuur);
                        }
                        foreach (var element in allObjects)
                        {
                            element.Paint();
                        }
                        break;
                    case 'D':
                        Console.WriteLine("met hoeveel wil je alles verplaatsen");
                        int verplaatsing = Convert.ToInt32(Console.ReadLine());
                        foreach (var muuur in Muren)
                        {
                            foreach (WallElement steen in muuur)
                            {
                                steen.Location.Y += verplaatsing;                                
                            }
                        }
                        foreach (var element in allObjects)
                        {
                            element.Location.Y += verplaatsing;
                        }
                        break;
                    default:
                        //Console.WriteLine($"An unexpected value ({caseSwitch})");
                        break;
                }
            } while (!(keuze == 'Q'));

            
            ////Muurtje
            //for (int i = 0; i < 4; i++)
            //{
            //    Point tempLoc = new Point(2 + i, 3);
            //    WallElement tempWall = new WallElement(tempLoc,'=',10.0);
            //    allObjects.Add(tempWall);
            //}

            ////Zetel
            //allObjects.Add(new Tafel(new Point(6, 8), 80));

            ////Teken alle objecten
            //for (int i = 0; i < allObjects.Count; i++)
            //{
            //    allObjects[i].Paint();
            //}

        }
    }
}
