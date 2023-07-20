using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookDemo.cs
{
    class BookDemo
    {
        static void Main(string[] args)
        {
            //declare and initailize objects
            TextBook maths = new TextBook();
            TextBook chem = new TextBook();
            CoffeTableBook coffee = new CoffeTableBook();
            CoffeTableBook tea = new CoffeTableBook();

            maths.ISBN = "1266-3636-37737";
            maths.Title = "Pure maths 1";
            maths.Author = "Ronald";
            maths.Price = 15.00;  //cost will be 20.00
            maths.GradeLevel = 12;
            Console.WriteLine(maths.ToString());
            Console.WriteLine();

            chem.ISBN = "24424-5536-77477";
            chem.Title = "Organic chem";
            chem.Author = "Lee";
            chem.Price = 45.95;
            chem.GradeLevel = 13;
            Console.WriteLine(chem.ToString());
            Console.WriteLine();

            coffee.ISBN = "2737-3773-6738";
            coffee.Title = "How to prepare coffee";
            coffee.Author = "arap boit";
            coffee.Price = 120.00;   // cost will be  100.00
            Console.WriteLine(coffee.ToString());
            Console.WriteLine();

            tea.ISBN = "35553-8388-2727";
            tea.Title = "Tea preparation";
            tea.Author = "musalia";
            tea.Price = 85.85;
            Console.WriteLine(tea.ToString());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
    public class Book  //base class
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return (Title + " written by " + Author + "\nhaving ISBN No " + ISBN + "\ncosts " + Price.ToString ("c")); 
        }
    }
    public class TextBook : Book //derived class
    {
        public const double LOWER_PRICE = 20.00;
        public const double HIGHER_PRICE = 80.00;
        int gradeLevel;
        public int GradeLevel
        {
            get
            {
                return gradeLevel;
            }
            set
            {
                gradeLevel = value;
            }
        }
        new public double Price
        {
            get
            {
                return base.Price ;
            }
            set
            {
                if (value < LOWER_PRICE)
                    base.Price = LOWER_PRICE;
                else
                    if (value > HIGHER_PRICE)
                        base.Price = HIGHER_PRICE;
                    else
                        base.Price = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\nand the Grade level is " + GradeLevel ;
        }
    }
    public class CoffeTableBook : Book //derived class
    {
        public const double LOWER_PRICE = 35.00;
        public const double HIGHER_PRICE = 100.00;

        new public double Price
        {
            get
            {
                return base.Price;
            }
            set
            {
                if (value < LOWER_PRICE)
                    base.Price = LOWER_PRICE;
                else
                    if (value > HIGHER_PRICE)
                        base.Price = HIGHER_PRICE;
                    else
                        base.Price = value;
            }
        }

    }
}
