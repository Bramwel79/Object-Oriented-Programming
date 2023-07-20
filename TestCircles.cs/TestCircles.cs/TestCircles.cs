using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestCircles.cs
{
    class TestCircles
    {
        static void Main(string[] args)
        {
            Circle saturn = new Circle();
            Circle jupiter = new Circle();
            Circle pluto = new Circle();
            saturn.Radius = 10;
            jupiter.Radius = 100;
            Display(saturn);
            Console.WriteLine();
            Display(jupiter);
            Console.WriteLine();
            Display(pluto);
            Console.ReadLine();

        }
        static void Display(Circle c)
        {
            Console.WriteLine("The Radius is {0}", c.Radius);
            Console.WriteLine("The Diameter is {0} ", c.Diameter);
            Console.WriteLine("The Area is {0}", c.Area.ToString ("F2"));
        }
    }
    class Circle
    {
        int radius;
        double area ;
        int diameter;

        
        public Circle ()
        {
            Radius = 1;
        }
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                diameter = 2 * radius;
                area =( Math.PI * (radius * radius));
            }

        }
        public double Area
        {
           get
            {
                return area;
            }  
        }
        public int Diameter
        {
            get
            {
                return diameter;
            }
            
        }
    }
    
}
