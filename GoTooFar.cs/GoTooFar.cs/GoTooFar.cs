using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoTooFar.cs
{
    class GoTooFar
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            try
            {
                for (int x = 0; x < 10; ++x)
                {
                    Console.WriteLine("Value of subscript " + x + " is " + numbers[x]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Now you've gone too far.");
            }


            Console.ReadLine();

            

        }
    }
}
