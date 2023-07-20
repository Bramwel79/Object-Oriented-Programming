using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoScouts.cs
{
    class DemoScouts
    {
        public const string motto = "to obey the Girl Scout law.";
        static void Main(string[] args)
        {
            
            GirlScout nancy = new GirlScout() ;
            GirlScout peninah = new GirlScout("Peninah",8000,34.95) ;
            Console.WriteLine("The Girl Scout motto is {0}",motto);
            Console.WriteLine();
            Console.WriteLine("Details for first Girl Scout");
            Console.WriteLine("****************************");
            Display(nancy);
            Console.WriteLine();
            Console.WriteLine("Details for second Girl Scout");
            Console.WriteLine("****************************");
            Display(peninah);
            Console.ReadLine();
        }
        public static void Display(GirlScout g)
        {
            Console.WriteLine("The Girl Scout name is {0}", g.GirlScoutName);
            Console.WriteLine("Her troop number is {0}", g.TroopNumber);
            Console.WriteLine("She owes {0}", g.DuesOwed);
        }
    }
    class GirlScout
    {
        String girlScoutName;
        int troopNumber;
        double duesOwed;
       

        public string GirlScoutName
        {
            get
            {
                return girlScoutName;
            }
        }
        public int TroopNumber
        {
            get
            {
                return troopNumber;
            }
        }
        public double DuesOwed
        {
            get
            {
                return duesOwed;
            }
        }
        public GirlScout()
        {
            girlScoutName = "Powell";
            troopNumber = 999;
            duesOwed = 0.00;
        }
        public GirlScout(String name, int number, double amount)
        {
            girlScoutName = name;
            troopNumber = number;
            duesOwed = amount;
        }
    }
}
