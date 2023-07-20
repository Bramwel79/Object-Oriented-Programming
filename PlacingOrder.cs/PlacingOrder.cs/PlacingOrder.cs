using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlacingOrder.cs
{
    class PlacingOrder
    {
        static void Main(string[] args)
        {
            string stocks;
            string quantities;
            int stockNumber;
            int quantityOrdered;

            Console.Write("Enter stock number>> ");
            stocks = Console.ReadLine();
            Console.Write("Enter quantity ordered>> ");
            quantities = Console.ReadLine();

            try
            {
                stockNumber = Convert.ToInt32(stocks);
                quantityOrdered = Convert.ToInt32(quantities);
            }
            catch (Exception   e)
            {
                Console.WriteLine(e.Message);
                stockNumber = 0;
                quantityOrdered = 0;
                
            }
            Console.WriteLine("Stock number is " + stockNumber);
            Console.WriteLine("Quantity ordered is " + quantityOrdered);
            Console.ReadLine();

        }
    }
}
