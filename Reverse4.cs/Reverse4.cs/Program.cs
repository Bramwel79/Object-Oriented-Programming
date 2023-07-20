using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse4.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 45;
            int middleInt = 67;
            int lastInt = 89;
            int fourthInt = 55;

            Console.WriteLine("Before Reversing, first Integer is {0}, second is {1} ,the third is {2}\n and the fourth is {3}", firstInt, middleInt, lastInt,fourthInt );
            ReverseIntegers(ref firstInt, ref middleInt, ref lastInt,ref fourthInt );
            Console.WriteLine("After Reversing ,first Integer is {0},second is {1} , the third is {2}\n and the fourth is {3}", firstInt, middleInt, lastInt,fourthInt );
            Console.ReadLine();
        }
        static void ReverseIntegers(ref int a, ref int b, ref int c,ref int d)
        {
            int temp;
            int temp2;
            temp = c;
            c = a;
            a = temp;
            temp2 = b;
            b = d;
            d = temp2;
        }
    }
}
