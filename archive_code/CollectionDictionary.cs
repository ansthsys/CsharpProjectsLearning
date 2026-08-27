using System;
using System.Collections.Generic;

/// <summary>
/// Dictionary&lt;TKey, TValue&gt;
/// <br /><br />
/// Demonstrates how to organize data using key-value pairs with
/// Dictionary&lt;TKey, TValue&gt;, including adding, retrieving, and
/// iterating through entries, as well as practical phonebook and
/// product ID-to-price mapping examples.
/// </summary>
namespace CollectionDictionary
{
  class Program
  {
    static void Main()
    {
      var students = new Dictionary<int, string>
            {
                { 101, "Ji-min Jo" },
                { 102, "Catalina Blaga" }
            };

      students.Add(103, "Milan Golob");

      foreach (var kvp in students)
      {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
      }

      var student = students[101];
      Console.WriteLine(student);

      var phonebook = new Dictionary<string, string>
            {
                { "Ji-min Jo", "312-555-0100" },
                { "Catalina Blaga", "251-555-0101" }
            };

      Console.WriteLine(phonebook["Ji-min Jo"]);

      var productPrices = new Dictionary<int, decimal>
            {
                { 201, 19.99m },
                { 202, 29.99m }
            };

      Console.WriteLine($"Product 201 costs ${productPrices[201]}");
    }
  }
}
