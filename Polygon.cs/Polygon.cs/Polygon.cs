using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polygon.cs
{
    //how to create automatic properties and use them
    // to initialize objects
    class Polygon
    {
       // private int numSides;
       // private double sideLength;

        public int NumSides { get; set; }
        public double SideLength { get; set; }

        public Polygon()
        {

            this.NumSides = 4;
            this.SideLength = 10.0;
        }
        static void Main(string[] args)
        {
            Polygon square = new Polygon();
            Polygon triangle = new Polygon() { NumSides = 3 };
            Polygon pentagon = new Polygon() { SideLength = 15.5, NumSides = 5 };

            Console.WriteLine("Square: number of sides is {0} , length of each side is {1}",
                                square.NumSides, square.SideLength);
            Console.WriteLine("Triangle: number of sides is {0}, length of each side is {1}",
                               triangle.NumSides, triangle.SideLength);
            Console.WriteLine("Pentagon: number of side is {0}, length of each side is {1}",
                                pentagon.NumSides, pentagon.SideLength);
            Console.ReadLine();
        }
    }
}
