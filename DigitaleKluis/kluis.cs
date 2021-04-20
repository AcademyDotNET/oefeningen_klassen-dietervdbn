using System;
using System.Collections.Generic;
using System.Text;

namespace DigitaleKluis
{
    class kluis
    {
        public kluis (int code)
        {
            Code = code;
        }
        private bool canShowCode = false;
        private int Code { get; set; }
        public bool CanShowCode
        {
            get
            {
                return canShowCode;
            }
            set
            {
                canShowCode = value;
            }
        }
        public int CodeLevel
        {
            get
            {
                return Code / 1000;
            }
        }
        public int VieuwCode
        {
            get
            {
                if (CanShowCode == true)
                {
                    return VieuwCode;
                }
                return -666;
            }
            private set
            {
                Code = value;
            }
        }
        private static int amountOfTries;
        public static int AmountOfTries
        {
            get
            {
                return amountOfTries;
            }
            set
            {
                amountOfTries = value;
            }
        }
        public bool TryCode()
        {
            Console.WriteLine("Doe een poging om de code te raden");
            int poging = Convert.ToInt32(Console.ReadLine());
            if (poging == -666)
            {
                Console.WriteLine("Cheater");
            }
            else if (poging == Code)
            {                
                Console.WriteLine("De code is juist");
                AmountOfTries++;
                return true;
            }
            else
            {                
                Console.WriteLine("jammer, foute code");
                AmountOfTries++;
                return false;
            }
            return false;
        }
    }
}
