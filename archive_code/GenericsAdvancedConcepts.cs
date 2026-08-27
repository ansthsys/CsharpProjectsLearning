using System;
using System.Collections.Generic;
using System.Numerics;

namespace GenericsAdvancedConcepts;

/// <summary>
/// Explore Advanced Generics Concepts
/// <br /><br />
/// Demonstrates generic interfaces, covariance, contravariance,
/// and generic math using type-safe and reusable generic code.
/// </summary>
public class Product : IComparable<Product>
{
  public string Name { get; set; }
  public decimal Price { get; set; }

  public int CompareTo(Product other)
  {
    return Price.CompareTo(other.Price);
  }
}

public class ProductComparer : IComparer<Product>
{
  public int Compare(Product x, Product y)
  {
    return x.Price.CompareTo(y.Price);
  }
}

public class Program
{
  static T Add<T>(T left, T right) where T : INumber<T>
  {
    return left + right;
  }

  public static void Main()
  {
    var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200 },
            new Product { Name = "Tablet", Price = 600 }
        };

    products.Sort(new ProductComparer());

    foreach (Product product in products)
    {
      Console.WriteLine($"{product.Name}: {product.Price}");
    }

    // Covariance: a more specific type can be assigned to a more general type.
    IEnumerable<string> strings = new List<string>();
    IEnumerable<object> objects = strings;

    // Contravariance: a more general type can be assigned to a more specific type.
    Action<object> handleObject = obj => Console.WriteLine(obj);
    Action<string> handleString = handleObject;

    handleString("Hello");

    // Generic math: the same method works with different numeric types.
    int result = Add(5, 10);
    double resultDouble = Add(5.5, 10.2);

    Console.WriteLine(result);
    Console.WriteLine(resultDouble);
  }
}