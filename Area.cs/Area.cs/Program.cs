using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateRectangleArea(23.45, 10.75);
            CalculateRectangleArea(12, 8);
            calculateRectangleArea(23.55, 12);
            Console.ReadLine();
        }
        static void CalculateRectangleArea(int length, int width)
        {
            int area;
            area = length * width;
            Console.WriteLine("The area of the rectangle  is {0}", area);
        }
        static void calculateRectangleArea(double length, double width)
        {
            double area;
            area = length * width;
            Console.WriteLine("The area of the rectangle  is {0}", area);
        }
        static void calculateRectangleArea(int length, double width)
        {
            double area;
            area = length * width;
            Console.WriteLine("The are of the rectangle  is {0}", area);
        }
    }
}
