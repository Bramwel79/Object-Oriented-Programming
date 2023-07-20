using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FractionDemo3.cs
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
        public Fraction(int wNumber, int upper, int lower) //takes 3 parameters
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
        public static void reduce(Fraction f)
        {
            if (f.Numerator < f.Denominator) //first scenario fraction numerator is less than its denominator e.g 2/4
            {
                for (int x = 1; x < f.Denominator; ++x)
                {
                    if ((f.Numerator % x == 0) && (f.Denominator % x == 0))
                    {
                        f.Numerator = f.Numerator / x;
                        f.Denominator = f.Denominator / x;

                    }

                }
            }
            else // second scenario fraction numerator is less than its denominator e.g 7/3
            {
                f.WholeNumber = f.Numerator / f.Denominator;
                f.Numerator = f.Numerator % f.Denominator;
                f.Denominator = f.Denominator;

            }

           /* Console.WriteLine("The whole number is {0}", f.WholeNumber);
            Console.WriteLine("The numerator is {0}", f.Numerator);
            Console.WriteLine("The denominator is {0}", f.Denominator);*/

        }
        //Overloading * operator to multiply two fraction objects
        public static Fraction operator *(Fraction one, Fraction two)
        {
            int denom = one.Denominator * two.Denominator;
            int numerator1 = ((one.WholeNumber * one.Denominator) + one.Numerator);
            int numerator2 = ((two.WholeNumber * two.Denominator) + two.Numerator);
            int totalNumerator = numerator1 * numerator2;

            Fraction temp = new Fraction(totalNumerator, denom);
            reduce(temp);
            return temp;
        }

        //Overloading + operator to add two fraction objects
        public static Fraction operator +(Fraction one, Fraction two)
        {
            int denom = one.Denominator * two.Denominator;
            int numerator1 = (((one.WholeNumber * one.Denominator) + one.Numerator) * (denom / one.Denominator)) ;
            int numerator2 = (((two.WholeNumber * two.Denominator) + two.Numerator) * (denom / two.Denominator ));
            int totalNumerator = numerator1 + numerator2;

            Fraction temp = new Fraction(totalNumerator ,denom );
            reduce(temp);
            return temp;
        }
        static void Main(string[] args)
        {
            int x ;
            int y;
            Fraction[] fraction = new Fraction[4];
            Fraction answers = new Fraction();
            for ( x = 0; x < fraction.Length; ++x)
            {
                fraction[x] = new Fraction();
                Console.Write("Enter fraction " + (x + 1) + " whole number: ");
                fraction[x].WholeNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter fraction " + (x + 1) + " numerator: ");
                fraction[x].Numerator = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter fraction " + (x + 1) + " denominator: ");
                fraction[x].Denominator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Addition");
            for (x = 0; x < fraction.Length; ++x)
            {
                for (y = 0; y < fraction.Length; ++y)
                {
                    answers = fraction[x] + fraction[y];
                    if (answers.WholeNumber > 0)
                      Console.WriteLine("{0} {1} / {2}", answers.WholeNumber, answers.Numerator, answers.Denominator);
                    
                    else
                      Console.WriteLine("{0} / {1}", answers.Numerator, answers.Denominator);
                    
                }
            }

            Console.WriteLine("Multiplication");
            for (x = 0; x < fraction.Length; ++x)
            {
                for (y = 0; y < fraction.Length; ++y)
                {
                    answers = fraction[x] * fraction[y];
                    if (answers.WholeNumber > 0)
                        Console.WriteLine("{0} {1} / {2}", answers.WholeNumber, answers.Numerator, answers.Denominator);
                    else
                        Console.WriteLine("{0} / {1}", answers.Numerator, answers.Denominator);
                }
            }
                      
            Console.ReadLine();

        }
    }
}


