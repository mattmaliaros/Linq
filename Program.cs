using System;
using System.Linq;

namespace Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
                var books = new BookRepository().GetBooks();

                //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
                //var book = books.First(b => b.Title == "C# Advanced Topics");
                var book = books.FirstOrDefault(b => b.Title == "Bleh");
                var bookTwo = books.Last(b => b.Title == "C# Advanced Topics");
                var pagedBooks = books.Skip(2).Take(3);
                var countBooks = books.Count();
                var maxPrice = books.Max(b => b.Price);
                var sumBooks = books.Sum(b => b.Price);


                //Null because "Bleh" doesn't exist
                try
                {
                    Console.WriteLine(book.Price);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Book is null");
                }

                Console.WriteLine(bookTwo.Price);

                foreach (var pageBook in pagedBooks)
                {
                    Console.WriteLine("\n" + pageBook.Title + "| " + pageBook.Price);
                }

                Console.WriteLine("\nTotal Books: " + countBooks );
                Console.WriteLine("\nMax Price: " + maxPrice);
                Console.WriteLine("\nSum Price: " +  sumBooks);


        }
    }
}