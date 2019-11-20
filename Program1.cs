using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program1
    {
        static void Main1(string[] args)
        {
            var books = new BookRepository().GetBooks();
            //Linq Query Operators
            //var cheaperBooks = from b in books
            //    where b.Price < 10
            //    orderby b.Title
            //    select b;

            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title); //Lambda Expressions using Linq

            //Same as using 'WHERE' in Linq
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //books.OrderBy(b => b.Title);
            foreach (var book in cheapBooks)
                //Console.WriteLine("Title: " + book.Title + "| Price: " + book.Price);
                Console.WriteLine(book);
        }

    }
}