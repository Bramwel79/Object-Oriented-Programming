using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookQuery2.cs
{
    class Book
    {

        public Book(string bookTitle, string bookAuthor, double bookPrice)
        {
            Title = bookTitle;
            Author = bookAuthor;
            Price = bookPrice;

        }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

    }
    class Program
    {

        static void Main(string[] args)
        {

            Book[] books = {new Book("access","microsoft",34.45),
                           new Book ("excel","microsoft",78.45),
                           new Book ("vba","microsoft",67.34),
                           new Book ("java","farrell",34.45),
                           new Book ("c#","farrell",34.12),
                           new Book ("html","carey",12.34),
                           new Book ("visual basic","ekedahl",23.45),
                           new Book ("f#","microsoft",45.55)
                           };

            string authorName;
            Console.Write("Enter an author name>> ");
            authorName = Console.ReadLine();

            var booksByAuthorName = from y in books
                                    orderby y.Title 
                                    group  y by  y.Author;

            foreach (var groupByAuthor in booksByAuthorName)
            {
                Console.WriteLine("Author: {0}",groupByAuthor.Key);
                foreach (var c in groupByAuthor)
                    Console.WriteLine("   {0, -30} {1,6}", c.Title, c.Price);
            }
           
            Console.ReadLine();

        }

    }
}
