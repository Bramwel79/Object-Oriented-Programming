using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionsOnPurpose3.cs
{
    class ExceptionsOnPurpose3
    {
        static void Main(string[] args)
        {
            int answer;
            int result = 0;
            int zero = 0;
            try
            {
                Console.Write("Enter an integer >> ");
                answer = Convert.ToInt32(Console.ReadLine());
                result = answer / zero;

            }

            catch (FormatException e)
            {
                Console.WriteLine("You did not enter an integer");

            }
            catch (DivideByZeroException e)
            {
                Console.Write("This is not your fault.");
                Console.WriteLine("You entered the integer correctly.");
                Console.WriteLine("The program divides by zero.");
            }
            Console.WriteLine("The answer is " + result);
            Console.ReadLine();

        }
    }
}

