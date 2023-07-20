using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSquares.cs
{
    class DemoSquares
    {
        static void Main(string[] args)
        {
            Square[] squareObjects = new Square[10];
            int x;
            int y;
            for (x = 0; x < squareObjects.Length; ++x)
            {
                squareObjects[x] = new Square(x + 1);
                
            }
            for (y = 0; y < squareObjects.Length; ++y)
            {
                Console.WriteLine("The Area of Square with Length {0,2} by {0,2} is {1,3}", squareObjects[y].Length, squareObjects[y].Area);
            }
            Console.ReadLine();
        }
    }
    class Square
    {
        double area;
        double length;
        public Square(int sideLength)
        {
            length = sideLength;
            ComputeSquareArea ();
        }
        public double Length
        {
            get
            {
                return length;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        private void ComputeSquareArea()
        {
           area = Length * Length ;
        }
    }
    
}
