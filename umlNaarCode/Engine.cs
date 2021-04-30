using System;
using System.Collections.Generic;
using System.Text;

namespace umlNaarCode
{
    class Engine
    {
        public Engine() 
        {
            Console.WriteLine("hoeveel pistons bevat de motor?");
            aantalpistons = Convert.ToInt32(Console.ReadLine());
        }
        public static int aantalpistons { get; set; }
        private Piston[] pistons = new Piston[aantalpistons];
        public Crankshaft crankshaft
        {
            get { return crankshaft; }
            set { crankshaft = value; }
        }
        public void MaakPistonsAan(Piston[] pistons)
        {
            for (int i = 0; i < pistons.Length; i++)
            {
                pistons[i] = new Piston();
            }
        }
    }
}
