namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book()
            {
                Title = "Ruby",
                Author = "Cynthia Bond",
                ISBN = "9789646543654",
                IsAvailable = true
            });
            library.BorrowBook("Python");
            library.BorrowBook("Javascript");
            library.ReturnBook("Python");
            Console.ReadLine();

        }
    }
}
