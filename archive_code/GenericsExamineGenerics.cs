using System;
using System.Collections.Generic;

namespace GenericsExamineGenerics;

/// <summary>
/// Examine Generics
/// <br /><br />
/// Demonstrates generic classes, generic methods, type parameters,
/// and generic collections while highlighting code reusability,
/// type safety, and performance benefits.
/// </summary>

public class Box<T>
{
  public T Item { get; set; }

  public void AddItem(T item)
  {
    Item = item;
  }
}

public class Program
{
  public static T GetFirstItem<T>(List<T> items)
  {
    return items[0];
  }

  public static void Main()
  {
    Box<int> numberBox = new Box<int>();
    numberBox.AddItem(10);
    Console.WriteLine(numberBox.Item);

    Box<string> textBox = new Box<string>();
    textBox.AddItem("Hello");
    Console.WriteLine(textBox.Item);

    List<int> numbers = new List<int>();
    numbers.Add(1);
    numbers.Add(2);
    numbers.Add(3);

    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }

    List<string> names = new List<string> { "Hannah", "Mario" };

    string firstName = GetFirstItem(names);

    Console.WriteLine(firstName);
  }
}