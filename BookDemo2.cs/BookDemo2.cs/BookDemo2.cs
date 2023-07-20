using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookDemo2.cs
{
    class BookDemo2
    {
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
            Console.WriteLine(biology.ToString());
            Console.WriteLine();

            sociology.ISBN = "234-234-678";
            sociology.Title = "Human sociology";
            sociology.Author = "Alexander";
            sociology.Price = 67.75;
            Console.WriteLine(sociology.ToString());
            Console.WriteLine();

            philosophy.ISBN = "222-4994-4884";
            philosophy.Title = "Greek philosophy";
            philosophy.Author = "Aries";
            philosophy.Price = 34.45;
            Console.WriteLine(philosophy.ToString());
            Console.WriteLine();

            Console.WriteLine("Comparing the Book objects yields the following");
            Console.WriteLine("***********************************************");
            
            if (biology .Equals (sociology ) )
                Console.WriteLine(biology .Title + " has the same ISBN number as " +sociology .Title );
            else
                Console.WriteLine(biology.Title + " does not have the same ISBN number as " + sociology.Title);
            if (biology.Equals(philosophy ))
                Console.WriteLine(biology.Title + " has the same ISBN number as " + philosophy . Title);
            else
                Console.WriteLine(biology.Title + " does not have the same ISBN number as " + philosophy.Title);
            if (sociology.Equals(philosophy ))
                Console.WriteLine(sociology.Title + " has the same ISBN number as " + philosophy.Title);
            else
                Console.WriteLine(sociology.Title + " does not have the same ISBN number as " + philosophy.Title);

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
            return (Title + " written by " + Author + "\nhaving ISBN No " + ISBN + "\ncosts " + Price.ToString("c"));
        }
        public override int GetHashCode()
        {
            return (Convert .ToInt32 (ISBN ));
        }
        public override bool Equals(Object o)
        {
            Book temp;
            bool result;
            temp = (Book)o;
            if (ISBN.Equals (temp.ISBN ))
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
