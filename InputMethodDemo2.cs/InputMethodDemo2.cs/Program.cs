using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputMethodDemo2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            InputMethod(out first, out second);
            Console.WriteLine("After InputMethod first is {0}", first);
            Console.WriteLine("and second is {0}", second);
            Console.ReadLine();
        }
        static void InputMethod(out int one,out int two)
        {
            one = DataEntry("first");
            two = DataEntry("second");
        }
        static int DataEntry(String input)
        {
            int number;
            Console.Write("Enter a number ");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            return number;
        }
        
    }
}
