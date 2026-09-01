using System;
using System.Text.Json;

namespace JsonSerializerClass
{
  /// <summary>
  /// Implement the JsonSerializer Class in C# Apps
  /// <br /><br />
  /// Demonstrates how to serialize C# objects into JSON strings and deserialize
  /// JSON strings back into C# objects using System.Text.Json.JsonSerializer.
  /// </summary>
  public class Employee
  {
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Address { get; set; } = string.Empty;
  }

  public class Program
  {
    public static void Main()
    {
      // 1. Serialization: Converting C# object to JSON string
      var customer = new Employee
      {
        Name = "Anette Thomsen",
        Age = 30,
        Address = "123 Main St"
      };

      string jsonString = JsonSerializer.Serialize(customer);
      Console.WriteLine("Serialized JSON:");
      Console.WriteLine(jsonString);

      Console.WriteLine();

      // 2. Deserialization: Converting JSON string back to C# object
      // Escaped string literal format
      string jsonString1 = "{\"Name\":\"Anette Thomsen\",\"Age\":30,\"Address\":\"123 Main St\"}";

      // Verbatim string literal format (@"")
      string jsonString2 = @"{""Name"":""Anette Thomsen"",""Age"":30,""Address"":""123 Main St""}";

      Employee? deserializedEmployee1 = JsonSerializer.Deserialize<Employee>(jsonString1);
      Employee? deserializedEmployee2 = JsonSerializer.Deserialize<Employee>(jsonString2);

      if (deserializedEmployee1 != null)
      {
        Console.WriteLine("Deserialized 1 Object:");
        Console.WriteLine($"Name: {deserializedEmployee1.Name}, Age: {deserializedEmployee1.Age}, Address: {deserializedEmployee1.Address}");
      }
      else
      {
        Console.WriteLine("Deserialization 1 failed.");
      }

      if (deserializedEmployee2 != null)
      {
        Console.WriteLine("Deserialized 2 Object:");
        Console.WriteLine($"Name: {deserializedEmployee2.Name}, Age: {deserializedEmployee2.Age}, Address: {deserializedEmployee2.Address}");
      }
      else
      {
        Console.WriteLine("Deserialization 2 failed.");
      }
    }
  }
}
