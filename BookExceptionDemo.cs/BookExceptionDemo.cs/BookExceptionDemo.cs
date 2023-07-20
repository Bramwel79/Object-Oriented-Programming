//Bramwel Nawate Abuko
//# 70587872
//Error handling C# project
/* project demonstrates how exception is handled using books as an example.
 * each book page costs 10 cents.Total book price should be equal to 
 * client quoted price else an exception is thrown.It will be caught by the BookException class and an error message shown.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookExceptionDemo.cs
{
    class BookExceptionDemo
    {
        static void Main(string[] args)
        {
            int x;
            const string COMPANY_NAME = "Peterman Publishing Company";
            Console.WriteLine(COMPANY_NAME);
            for (x = 0; x < COMPANY_NAME.Length; ++x)
            {
                Console.Write("*");
            }
            Console.WriteLine();

                try
                {
                    Book cSharp = new Book("CSharp Programming", "Farrell", 85.00, 850);  //meets ratio
                    Book vb = new Book("VisualBasic.Net", "Ekedahl", 230.55, 900);  //does not meet ratio
                    Book C = new Book("C Programming", "Horton", 200.50, 500); //does not meet ratio
                    Book fSharp = new Book("FSharp Progarmming", "Ted", 45.00, 450); //meets ratio
                }
                catch (BookException be)
                {
                    Console.WriteLine(be.Message);

                }

            
            Console.ReadLine();
        }
    }
    public class BookException :Exception  
    {
        public BookException(string title,double price,int pages)
        {
            Console.WriteLine("For " + title + "," + " ratio is invalid." +
                "\n...price is " + price .ToString("c") + " for " + pages + " pages." );
        }
        
    }
    public class Book
    {
        string bookTitle;
        string bookAuthor;
        double bookPrice;
        int numberOfPages;
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public double BookPrice { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string t, string a, double p, int no)
        {
            bookTitle = t;
            bookAuthor = a;
            bookPrice = p;
            numberOfPages = no;

            double testPrice;
            const int CENTS_IN_A_DOLLAR = 100;
            const int PRICE_PER_PAGE = 10;
            testPrice = numberOfPages * PRICE_PER_PAGE  / CENTS_IN_A_DOLLAR;

            if (testPrice != bookPrice)
                throw new BookException(bookTitle ,bookPrice ,numberOfPages );
            
        }


    }
}
