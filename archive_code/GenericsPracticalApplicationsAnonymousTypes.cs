using System;
using System.Linq;

namespace GenericsPracticalApplicationsAnonymousTypes;

/// <summary>
/// Practical Applications of Anonymous Types
/// <br /><br />
/// Demonstrates how to create anonymous types, use read-only properties,
/// project data with LINQ, and compare anonymous types with tuple types.
/// </summary>
public class Program
{
  public static void Main()
  {
    var value = new
    {
      Amount = 108,
      Message = "Hello"
    };

    Console.WriteLine($"{value.Amount} - {value.Message}");

    var product = new
    {
      Name = "Laptop",
      Price = 1200
    };

    Console.WriteLine(
        $"Product: {product.Name}, Price: {product.Price}"
    );

    var products = new[]
    {
            new { Name = "Laptop", Price = 1200 },
            new { Name = "Tablet", Price = 600 }
        };

    var filteredProducts =
        from p in products
        where p.Price > 1000
        select new
        {
          p.Name,
          p.Price
        };

    foreach (var filteredProduct in filteredProducts)
    {
      Console.WriteLine(
          $"Name: {filteredProduct.Name}, Price: {filteredProduct.Price}"
      );
    }

    var customer = new
    {
      Name = "Mario Rogers",
      Age = 30
    };

    Console.WriteLine(
        $"Customer: {customer.Name}, Age: {customer.Age}"
    );
  }
}