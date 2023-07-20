using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingSum.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToTest = {12,34,89,35,61};
            Sum(12);
            Sum(20,34,67);
            Sum (23,67,89,12,65);
            Sum(arrayToTest);
            Console.ReadLine();

        }
        static void Sum(params int[] numbers)
        {
            int sum = 0;
            int x;
            for (x = 0; x < numbers.Length; ++x)
            {
                sum += numbers[x];

            }
            Console.WriteLine("The sum of the number(s) is {0}", sum);
        }
    }
}
