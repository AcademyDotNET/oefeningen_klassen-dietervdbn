using System;
using System.Collections.Generic;
using System.Text;

namespace Moederbord
{
    enum ramType {DDR3 = 1, DDR4, DDR5, SDRAM, DIMM, RIMM, SIMM }
    class Ram
    {
        public Ram ()
        {
            Console.WriteLine("welk type ram? 1:DDR3, 2:DDR4, 3:DDR5, 4:SDRAM, 5:DIMM, 6:RIMM, 7:SIMM");
            int TypeRam = Convert.ToInt32(Console.ReadLine());
            switch (TypeRam)
            {
                case 1:
                    TypeR = ramType.DDR3;
                    break;
                case 2:
                    TypeR = ramType.DDR4;
                    break;
                case 3:
                    TypeR = ramType.DDR5;
                    break;
                case 4:
                    TypeR = ramType.SDRAM;
                    break;
                case 5:
                    TypeR = ramType.DIMM;
                    break;
                case 6:
                    TypeR = ramType.RIMM;
                    break;
                case 7:
                    TypeR = ramType.SIMM;
                    break;
                default:
                    TypeR = ramType.DDR4;
                    break;
            }
            Console.WriteLine("Hoeveel GB");
            Groodte = Convert.ToInt32(Console.ReadLine());
        }
        public ramType TypeR { get; set; }
        public int Groodte{ get; set; }
        public string Tostring()
        {
            return ($"{TypeR} {Groodte} GB");
        }
    }
}
