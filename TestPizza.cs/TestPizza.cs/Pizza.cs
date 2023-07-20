using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPizza.cs
{
    class Pizza
    {
        String toppings;
        int diameterInInches;
        double price;

        static void Main(string[] args)
        {
            Pizza TestPizza = new Pizza("King size",35,23.45);
            
            Console.WriteLine(TestPizza.toppings);
            Console.WriteLine(TestPizza.diameterInInches);
            Console.WriteLine(TestPizza.price);

            
            Console.ReadLine();
        }
        public String Toppings
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
        public int DiameterInInches
        {
            get
            {
                return diameterInInches;
            }
            set
            {
                diameterInInches = value;
            }
        }
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

        
        public Pizza(String s, int d, double p)
        {
            Toppings = s;
            DiameterInInches = d;
            Price = p;
        }
    }
}
