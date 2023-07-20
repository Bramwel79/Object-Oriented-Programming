using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqIntegersDemo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int x;
            int number;

            //get input from client
            for (x = 0; x < numbers.Length; ++x)
            {
                try
                {
                    Console.Write("Enter value for number " + (x + 1) + " : ");
                    number = Convert .ToInt32 ( Console.ReadLine());
                    numbers[x] = number;
                }
                catch( Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //display output in descending order
            var sortedNumbers = from y in numbers
                                orderby y descending 
                                select y;
            Console.WriteLine("\n");
            Console.WriteLine("Numbers sorted in descending order:");
            Console.WriteLine("***********************************");

            foreach (var y in sortedNumbers)
            {

                Console.WriteLine("{0}", y);
            }

            Console.ReadLine();
        }
    }
}
