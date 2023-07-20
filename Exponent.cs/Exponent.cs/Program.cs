using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int squareAnswer;
            int cubeAnswer;
            Console.Write("Enter a number ");
            number = Convert.ToInt32(Console.ReadLine());
            squareAnswer = Square(number);
            cubeAnswer =  Cube(number);
            Console.WriteLine ("The square result is {0} and the cube result is {1}",squareAnswer ,cubeAnswer );
            Console.ReadLine();


        }
        static int Square(int numberToSquare)
        {
            int squareResult = numberToSquare * numberToSquare;
            return squareResult;
        }
        static int Cube(int numberToCube)
        {
            int cubeResult = numberToCube * numberToCube * numberToCube;
            return cubeResult;
        }
    }
}
