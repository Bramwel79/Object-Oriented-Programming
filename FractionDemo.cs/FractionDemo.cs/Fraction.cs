using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionDemo.cs
{
    class Fraction
    {
        //instance variables
        int wholeNumber;
        int numerator;
        int denominator;

        //getters and setters of the instance variables
        public int WholeNumber
        {
            get
            {
                return wholeNumber;
            }
            set
            {
                wholeNumber = value;
            }
        }
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;
                if (denominator == 0) // do not allow a denominator of 0
                    denominator = 1;
            }
        }
        //3 constructors for Fraction class
        public Fraction(int wNumber,int upper,int lower) //takes 3 parameters
        {
            wholeNumber = wNumber;
            numerator = upper;
            denominator = lower;
        }

        public Fraction(int upper, int lower)//takes 2 parameters and initializes wholeNumber to 0
        {
            wholeNumber = 0;
            numerator = upper;
            denominator = lower;
        }

        public Fraction() //takes no parameters and initializes  wholeNumber and numerator to 0 denominator to 1
        {
            wholeNumber = 0;
            numerator = 0;
            denominator = 1;
        }

        //method to reduce a fraction object to proper form e;g 9/4 to 4 1/2
        public  static void reduce(Fraction f)
        {
            if (f.Numerator  < f.Denominator) //first scenario fraction numerator is less than its denominator e.g 2/4
            {
                for (int x = 1; x < f.Denominator ; ++x)
                {
                    if ((f.Numerator  % x == 0) && (f.Denominator  % x == 0))
                    {
                        f.Numerator = f.Numerator / x;
                        f.Denominator = f.Denominator  / x;
                        
                    }

                }
            }
            else // second scenario fraction numerator is less than its denominator e.g 7/3
            {
                f.WholeNumber = f.Numerator / f.Denominator;
                f.Numerator = f.Numerator % f.Denominator;
                f.Denominator = f.Denominator;
                              
            }
            
            Console.WriteLine("The whole number is {0}", f.WholeNumber);
            Console.WriteLine("The numerator is {0}", f.Numerator);
            Console.WriteLine("The denominator is {0}", f.Denominator);

        }
        //Overloading + operator to add two fraction objects
        public static Fraction operator+(Fraction one, Fraction two)
        {
            int denom = one.Denominator * two.Denominator;
            int numerator1 = (((one.WholeNumber * one.Denominator) + one.Numerator) * (denom / one.Denominator));
            int numerator2 = (((two.WholeNumber * two.Denominator) + two.Numerator) * (denom / two.Denominator));
            int totalNumerator = numerator1 + numerator2;

            Fraction temp = new Fraction(totalNumerator, denom);
            return temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The first fraction data is");
            Console.WriteLine("**************************");
            Fraction a = new Fraction(9,4);
            reduce(a);
            Console.WriteLine ();
            Console.WriteLine("The second fraction data is ");
            Console.WriteLine("****************************");
            Fraction b = new Fraction(8,5);
            reduce(b);
            Console.WriteLine();
            Console.WriteLine("After adding the two fractions....");
            Fraction c = a + b;
            reduce(c);
            Console.WriteLine();

            if (c.WholeNumber > 0)
            {
                Console.WriteLine("The solution is {0} {1} / {2}", c.WholeNumber, c.Numerator, c.Denominator);
            }
            else //do not display 0 as whole number
            {
                Console.WriteLine("The solution is {0} / {1}", c.Numerator, c.Denominator);
            } 
            Console.ReadLine();
            
        }
    }
}
