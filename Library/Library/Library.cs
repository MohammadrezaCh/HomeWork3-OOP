using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        List<Book> books;
        public Library()
        {
            books = new List<Book>
                {new Book
                {
                    Title = "C# book",
                    Author = "Eleventh Edition",
                    ISBN = "9789641234561",
                    IsAvailable = false
                },
                new Book
                {
                    Title = "Python",
                    Author = "Allen B. Downey",
                    ISBN = "9789646543212",
                    IsAvailable = true
                },
                new Book
                {
                    Title = "Javascript",
                    Author = "Robin Wieruch",
                    ISBN = "9789649876543",
                    IsAvailable = true
                }};

        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void BorrowBook(string Title)
        {
            Book book = books.FirstOrDefault(x => x.Title == Title);
            if (book == null)
            {
                Console.WriteLine("Not found.");
                return;
            }
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine("The book was successfully loaned.");
            }
            else
            {
                Console.WriteLine("The desired book was not found.");
            }
        }
        public void ReturnBook(string Title)
        {
            Book book = books.FirstOrDefault(x => x.Title == Title);
            if (book == null)
            {
                Console.WriteLine("Not found.");
                return;
            }
            if (book.IsAvailable)
            {
                Console.WriteLine("This book was already available in the library.");
            }
            else
            {
                book.IsAvailable = true;
                Console.WriteLine("The book was successfully returned.");
            }
        }
    }
}
