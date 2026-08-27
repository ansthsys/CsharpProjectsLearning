using System;
using System.Collections.Generic;

/// <summary>
/// Ensuring Uniqueness with HashSet&lt;T&gt;
/// <br /><br />
/// Demonstrates how HashSet&lt;T&gt; manages unordered collections of unique
/// elements, including adding items, checking for existing items, preventing
/// duplicates, and managing unique email addresses.
/// </summary>
namespace CollectionHashSet
{
  internal class Program
  {
    static void Main()
    {
      HashSet<string> names = new HashSet<string>();

      names.Add("Haneul");
      names.Add("Magda");

      Console.WriteLine("Names:");

      foreach (string name in names)
      {
        Console.WriteLine(name);
      }

      if (names.Contains("Haneul"))
      {
        Console.WriteLine("\nHaneul is in the collection.");
      }

      names.Add("Mia");
      names.Add("Mia");

      Console.WriteLine("\nNames after adding Mia twice:");

      foreach (string name in names)
      {
        Console.WriteLine(name);
      }

      Console.WriteLine(
          $"\nNumber of unique names: {names.Count}"
      );

      HashSet<string> emailAddresses = new HashSet<string>();

      emailAddresses.Add("user1@example.com");
      emailAddresses.Add("user2@example.com");
      emailAddresses.Add("user1@example.com");

      Console.WriteLine("\nUnique email addresses:");

      foreach (string email in emailAddresses)
      {
        Console.WriteLine(email);
      }

      Console.WriteLine(
          $"\nNumber of unique email addresses: " +
          $"{emailAddresses.Count}"
      );
    }
  }
}
