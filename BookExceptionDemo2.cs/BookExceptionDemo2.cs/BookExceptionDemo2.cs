using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookExceptionDemo2.cs
{
    class BookExceptionDemo2
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            const string COMPANY_NAME = "Peterman Publishing Company";
            Console.WriteLine(COMPANY_NAME);
            for (x = 0; x < COMPANY_NAME.Length; ++x)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Book[] books = new Book[5];
            string bkName;
            string bkAuthor;
            double bkPrice;
            int bkPages;
            //fill book array with 5 book objects throw exception if necessary
            for (x = 0; x < books.Length; ++x)
            {

                try
                {
                    Console.Write("Enter Book's Title>> ");
                    bkName = Console.ReadLine();
                    Console.Write("Enter Book's Author>> ");
                    bkAuthor = Console.ReadLine();
                    Console.Write("Enter Book Price>> ");
                    bkPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number of pages in the book>> ");
                    bkPages = Convert.ToInt32(Console.ReadLine());
                    books[x] = new Book(bkName, bkAuthor, bkPrice, bkPages);
                    Console.WriteLine();

                }
                catch (BookException be)
                {
                    Console.WriteLine(be.Message);

                }
                catch (NullReferenceException nr)
                {
                    Console.WriteLine(nr.Message);
                }
                

            }
            //display the data
            for (y = 0; y < books.Length; ++y)
            {
               
                Console.WriteLine( books[y].ToString());
            }

            Console.ReadLine();
        }
    }
}
    public class BookException : Exception
    {
        public BookException(string title, double price, int pages)
        {
            Console.WriteLine("For " + title + "," + " ratio is invalid." +
                "\n...price is " + price.ToString("c") + " for " + pages + " pages.");
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
            testPrice = numberOfPages * PRICE_PER_PAGE / CENTS_IN_A_DOLLAR;

            if (testPrice != bookPrice)
                throw new BookException(bookTitle, bookPrice, numberOfPages);
           

        }
        public new string ToString()
        {
            return (bookTitle + " written by " + bookAuthor + " contains " + numberOfPages +
                "\nand has a price tag of " + bookPrice);
        }

    }

