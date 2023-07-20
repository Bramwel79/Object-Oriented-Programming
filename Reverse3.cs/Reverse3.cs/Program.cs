using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 45;
            int middleInt = 67;
            int lastInt = 89;
            Console.WriteLine("Before Reversing, first Integer is {0}, second is {1} and the third is {2}", firstInt, middleInt, lastInt);
            ReverseIntegers(ref firstInt, ref middleInt, ref lastInt);
            Console.WriteLine("After Reversing ,first Integer is {0},second is {1} and the third is {2}", firstInt, middleInt, lastInt);
            Console.ReadLine();
        }
        static void ReverseIntegers(ref int a, ref int b, ref int c)
        {
            int temp;
            temp = c;
            c = a;
            a = temp;

        }
    }
}
