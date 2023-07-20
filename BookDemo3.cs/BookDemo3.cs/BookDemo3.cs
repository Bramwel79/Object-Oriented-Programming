using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookDemo3.cs
{
    class BookDemo3
    {
        public const string joiner = "by";
        static void Main(string[] args)
        {
            //declare and initialize objects
            Book biology = new Book();
            Book sociology = new Book();
            Book philosophy = new Book();

            biology.ISBN = "234-234-678";
            biology.Title = "Animal biology";
            biology.Author = "sheiner";
            biology.Price = 23.55;
            
            sociology.ISBN = "234-234-678";
            sociology.Title = "Human sociology";
            sociology.Author = "Alexander";
            sociology.Price = 67.75;

            DisplayTitleAndAuthor(biology);
            Console.WriteLine();
            DisplayTitleAndAuthor(sociology);

            Console.ReadLine();
        }

        public static void DisplayTitleAndAuthor(Book b)
        {
            Console.WriteLine(b.Title + " " + joiner + " " + b.Author);
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
            return (Title + " written by " + Author + "\nhaving ISBN No " + ISBN + "\ncosts " + Price.ToString("c"));
        }
        public override int GetHashCode()
        {
            return (Convert.ToInt32(ISBN));
        }
        public override bool Equals(Object o)
        {
            Book temp;
            bool result;
            temp = (Book)o;
            if (ISBN.Equals(temp.ISBN))
                result = true;
            else
                result = false;
            return result;

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
        public override string ToString()
        {
            return base.ToString() + "\nand the Grade level is " + GradeLevel;
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
