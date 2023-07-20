using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapesDemo.cs
{
  public class ShapesDemo
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(25, 15);
            DisplayGeometricFigure(rect);
            Console.WriteLine();
            Square monastiraki = new Square(10,12);
            Square suntagma = new Square(10);
            DisplayGeometricFigure(monastiraki);
            DisplayGeometricFigure(suntagma);
            Console.WriteLine();
            Triangle tset = new Triangle(10, 5);
            DisplayGeometricFigure(tset);
            Console.WriteLine();
            Console.ReadLine();

        }
        internal  static void DisplayGeometricFigure(GeometricFigure figure)
        {
            Console.WriteLine(figure.GetType() + " has a Height of " + figure.Height +
                "\nand Width of " + figure.Width +
                "\nComputed Area is " + figure.Area );
        }
        
    }
    
    public abstract class GeometricFigure
    {
       protected  int height;
       protected  int width;
       protected  int area;

       public GeometricFigure(int h, int w)
       {
           Height = h;
           Width = w;
       }
       public int Height
       {
           get
           {
               return height;
           }
           set
           {
               height = value;
               ComputeArea();
           }
       }
       public int Width
       {
           get
           {
               return width;
           }
           set
           {
               width = value;
               ComputeArea();
           }
       }
        public int Area
        {
            get
            {
                return area;
            }
            
        }
       
        public abstract void ComputeArea();
        
        
    }
    

    public class Rectangle : GeometricFigure
    {
        public Rectangle(int h, int w) : base(h,w)
        {
           
        }
        public override void ComputeArea()
        {
            area =   Height * Width ;
        }
    }

    public class Square : Rectangle 
    {
        public Square(int w, int h) : base(w,w)
        {
            
        }
        public Square(int w): base(w,w)
        {
            
        }
        public new int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                width = height;
                ComputeArea();
            }
        }
        public new int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                height = width;
                Console.WriteLine("XXX");
                ComputeArea();
            }
        }

        
    }

    public class Triangle : GeometricFigure
    {
        public Triangle(int h, int w): base(h,w)
        {
            
        }
        public override void ComputeArea()
        {
            area =  (Height/2) * Width;
        }
    }

}
