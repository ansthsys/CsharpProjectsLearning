/// <summary>
/// Tightly Coupled Code
/// <br /><br />
/// Demonstrates tightly coupled code through a direct dependency between
/// Library and BorrowableBook. The example shows how direct dependencies
/// can limit extensibility and violate the Open/Closed Principle.
/// </summary>

namespace InterfaceTightlyCoupledCode
{
    public class BorrowableBook
    {
        public string Title { get; set; }

        public bool IsAvailable { get; private set; } = true;

        public BorrowableBook(string title)
        {
            Title = title;
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"You have borrowed \"{Title}\".");
            }
            else
            {
                Console.WriteLine($"\"{Title}\" is already borrowed.");
            }
        }
    }

    public class Library
    {
        private BorrowableBook _book;

        public Library(BorrowableBook book)
        {
            _book = book;
        }

        public void BorrowBook()
        {
            if (_book.IsAvailable)
            {
                _book.Borrow();
            }
            else
            {
                Console.WriteLine("The book is not available.");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            BorrowableBook book = new BorrowableBook("C# Programming");
            Library library = new Library(book);

            library.BorrowBook();
            library.BorrowBook();
        }
    }
}
