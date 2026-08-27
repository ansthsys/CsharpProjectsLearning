using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Implement Ordered Collections with List&lt;T&gt;
/// <br /><br />
/// Demonstrates how List&lt;T&gt; stores ordered, strongly typed elements,
/// including adding, removing, indexing, enumerating, dynamic resizing,
/// and managing custom objects with a list.
/// </summary>
namespace CollectionList
{
  /// <summary>
  /// Represents a student stored in a List&lt;Student&gt; collection.
  /// </summary>
  public class Student
  {
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
  }

  internal class Program
  {
    static void Main()
    {
      List<string> books = new List<string>();

      books.Add("Book A");
      books.Add("Book B");
      books.Add("Book C");

      books.Remove("Book A");

      Console.WriteLine("Books:");

      foreach (string book in books)
      {
        Console.WriteLine(book);
      }

      Console.WriteLine($"First book: {books[0]}");

      List<string> filteredBooks = books
          .Where(book => book.Contains("B"))
          .ToList();

      Console.WriteLine("\nFiltered books:");

      foreach (string book in filteredBooks)
      {
        Console.WriteLine(book);
      }

      List<Student> students = new List<Student>
            {
                new Student { Name = "Haneul", Age = 20 },
                new Student { Name = "Magda", Age = 22 }
            };

      students.Add(new Student
      {
        Name = "Dale",
        Age = 23
      });

      students.RemoveAt(0);

      Console.WriteLine("\nStudents:");

      foreach (Student student in students)
      {
        Console.WriteLine(
            $"Name: {student.Name}, Age: {student.Age}"
        );
      }

      students.Clear();

      Console.WriteLine($"\nStudents after Clear(): {students.Count}");
    }
  }
}