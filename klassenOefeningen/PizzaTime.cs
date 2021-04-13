using System;
using System.Collections.Generic;
using System.Text;

namespace klassenOefeningen
{
    class Pizza
    {
        private string toppings;
        public string Toppings
        {
            get
            {
                return toppings;
            }
            set
            {
                toppings = value;
            }
        }
        private int diameter;
        public int Diameter    
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
