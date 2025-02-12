using System;
using System.Collections.Generic;

namespace adv_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Book> books = new List<Book>
            {
                new Book("FC Barcalona", "FC", "Barce_10", new DateTime(1850, 4, 10)),
                new Book("iuyjt", "mohamed", "99", new DateTime(1960, 7, 11)),
                new Book("the goat", "leo messi", "10", new DateTime(1987, 6, 24))
            };

            //  custom delegate
            Console.WriteLine("custom delegate:");
            LibraryEngin.ProcessBook(books, BookFunctions.GetTitle);
            Console.WriteLine("----------------------");
            //  Func delegate
            Console.WriteLine("built in delegatte:");
            LibraryEngin.ProcessBooks(books, BookFunctions.GetAuthor);
            Console.WriteLine("----------------------");

            // anonymous method 
            Console.WriteLine(" anonymous method:");
            LibraryEngin.ProcessBooks(books, delegate (Book book) { return book.Title; });
            Console.WriteLine("----------------------");

            // lambda expression 
            Console.WriteLine("lambda expression:");
            LibraryEngin.ProcessBooks(books, book => book.Title.ToString());
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }

        public Book(string title, string author, string isbn, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = publicationDate;
        }

        public override string ToString()
        {
            return $"book title: {Title}, authhor: {Author}, isbn: {ISBN}, puplishdate: {PublicationDate}";
        }
    }

    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }

        public static string GetAuthor(Book book)
        {
            return book.Author;
        }

        public static string GetISBN(Book book)
        {
            return book.ISBN;
        }

        public static DateTime GetPublicationDate(Book book)
        {
            return book.PublicationDate;
        }
    }

    public class LibraryEngin
    {
        public delegate string BookDelegate(Book book);

        public static void ProcessBook(List<Book> books, BookDelegate bookDelegate)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }
        }

        public static void ProcessBooks(List<Book> books, Func<Book, string> bookDelegate)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }
        }
    }
}