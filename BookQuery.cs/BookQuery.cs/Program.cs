using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookQuery.cs
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
                                    where y.Author == authorName
                                    select y;
            foreach (var b in booksByAuthorName)
                Console.WriteLine("   {0, -30} {1,6}", b.Title, b.Price);
            if (booksByAuthorName.Count() == 0)
            {
                Console.WriteLine("no book was found");
            }
            else
            {
                Console.WriteLine("Count of books is {0}", booksByAuthorName.Count());
            }
            Console.ReadLine();

        }

    }
}
