using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenAndOdd.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            int number;
            int x;

            //get input from client - 8 integers
            for (x = 0; x < numbers.Length; ++x)
            {
                try
                {
                    Console.Write("Enter value for integer no " + (x + 1) + " : ");
                    number = Convert.ToInt32(Console.ReadLine());
                    numbers[x] = number;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //sieve even numbers from numbers array
            var even = from y in numbers
                       where y % 2 == 0
                       select y ;

            Console.WriteLine("The even numbers are:");
            Console.WriteLine("*********************");

            foreach (var y in even )
            {
                Console.Write ("{0,5}",y);
            }

            //sieve odd numbers from numbers array
            var odd = from y in numbers
                       where y % 2 != 0
                       select y;

            Console.WriteLine("\nThe odd numbers are:");
            Console.WriteLine("*********************");

            foreach (var y in odd)
            {
                Console.Write("{0,5}", y);
            }
            Console.ReadLine();

        }
    }
}
