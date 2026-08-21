/// <summary>
/// Refactor Using Interfaces
/// <br /><br />
/// Demonstrates how to refactor tightly coupled code by introducing the
/// IBorrowable interface and dependency injection. The example shows how
/// Library can work with different borrowable item implementations without
/// depending directly on a specific class.
/// </summary>

namespace InterfaceTightlyCoupledCodeRefactored
{
    public interface IBorrowable
    {
        bool IsAvailable { get; }

        void Borrow();
    }

    public class BorrowableBook : IBorrowable
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

    public class BorrowableDVD : IBorrowable
    {
        public string Title { get; set; }

        public bool IsAvailable { get; private set; } = true;

        public BorrowableDVD(string title)
        {
            Title = title;
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"You have borrowed the DVD \"{Title}\".");
            }
            else
            {
                Console.WriteLine($"The DVD \"{Title}\" is already borrowed.");
            }
        }
    }

    public class Library
    {
        private IBorrowable _item;

        public Library(IBorrowable item)
        {
            _item = item;
        }

        public void BorrowItem()
        {
            if (_item.IsAvailable)
            {
                _item.Borrow();
            }
            else
            {
                Console.WriteLine("The item is not available.");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            IBorrowable book =
                new BorrowableBook("Adventure Works Cycles");

            IBorrowable dvd =
                new BorrowableDVD("Graphic Design Institute");

            Library bookLibrary = new Library(book);
            Library dvdLibrary = new Library(dvd);

            bookLibrary.BorrowItem();
            bookLibrary.BorrowItem();

            Console.WriteLine();

            dvdLibrary.BorrowItem();
            dvdLibrary.BorrowItem();
        }
    }
}
