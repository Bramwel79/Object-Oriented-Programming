using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlacingOrder2.cs
{
    class PlacingOrder2
    {
        static void Main(string[] args)
        {
            
            int stockNumber;
            int quantityOrdered;
            stockNumber = DataEntry ("Enter stock number>> ");
            quantityOrdered = DataEntry ("Enter quantity ordered>> ");
            Console.WriteLine("Stock number is " + stockNumber);
            Console.WriteLine("Quantity ordered is " + quantityOrdered);
            Console.ReadLine();
        }

        public static int DataEntry(string s)
        {
            string input;
            int num = 0;

            try
            {
                Console.Write(s);
                input = Console.ReadLine();
                num = Convert.ToInt32(input);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return num;
        }
    }
}

