using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace JsonCustomizeDeserializationBehavior
{
  /// <summary>
  /// Customize Deserialization Behavior
  /// <br /><br />
  /// Demonstrates how to control JSON deserialization behavior using JsonSerializerOptions,
  /// enforcing required properties (required modifier, [JsonRequired], contract model),
  /// handling object creation (Replace vs. Populate), and reading JSON data from files.
  /// </summary>

  // 1. Models demonstrating Required Properties
  public class JsonPersonWithRequiredKeyword
  {
    public required string Name { get; set; }
    public int Age { get; set; }
  }

  public class JsonPersonWithRequiredAttribute
  {
    [JsonRequired]
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
  }

  public class JsonPersonContractModel
  {
    public required string Name { get; set; }
    public int Age { get; set; }
  }

  // 2. Models demonstrating Object Creation Handling (Replace vs. Populate)
  public class JsonClassDefaultReplace
  {
    public List<int> Numbers1 { get; } = new() { 1, 2, 3 };
    public List<int> Numbers2 { get; set; } = new() { 1, 2, 3 };
  }

  [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
  public class JsonClassWithPopulateAttribute
  {
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Replace)]
    public List<int> Numbers1 { get; } = new() { 1, 2, 3 };
    public List<int> Numbers2 { get; set; } = new() { 1, 2, 3 };
  }

  // 3. Model class for file reading demonstration
  public class JsonBankCustomer
  {
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Address { get; set; } = string.Empty;
  }

  public class Program
  {
    public static void Main()
    {
      // --- Section 1: Required Properties Handling ---
      Console.WriteLine("--- 1. Required Properties Handling ---");

      // A. Required C# Keyword
      try
      {
        string jsonMissingName = """{"Age": 42}""";
        JsonSerializer.Deserialize<JsonPersonWithRequiredKeyword>(jsonMissingName);
      }
      catch (JsonException ex)
      {
        Console.WriteLine($"[C# required Keyword] Exception caught: {ex.Message}");
      }

      // B. [JsonRequired] Attribute
      try
      {
        string jsonMissingName = """{"Age": 42}""";
        JsonSerializer.Deserialize<JsonPersonWithRequiredAttribute>(jsonMissingName);
      }
      catch (JsonException ex)
      {
        Console.WriteLine($"[[JsonRequired] Attribute] Exception caught: {ex.Message}");
      }

      // C. Overriding IsRequired via Contract Model
      var contractOptions = new JsonSerializerOptions
      {
        TypeInfoResolver = new DefaultJsonTypeInfoResolver
        {
          Modifiers =
                    {
                        static typeInfo =>
                        {
                            if (typeInfo.Kind != JsonTypeInfoKind.Object)
                                return;

                            foreach (JsonPropertyInfo propertyInfo in typeInfo.Properties)
                            {
                                propertyInfo.IsRequired = false;
                            }
                        }
                    }
        }
      };

      var personFromContract = JsonSerializer.Deserialize<JsonPersonContractModel>("""{"Age": 42}""", contractOptions);
      Console.WriteLine($"[Contract Model Override] Age: {personFromContract?.Age}, Name: '{personFromContract?.Name}'");
      Console.WriteLine();

      // --- Section 2: Object Creation Handling (Replace vs. Populate) ---
      Console.WriteLine("--- 2. Object Creation Handling (Replace vs. Populate) ---");
      string listJson = """{"Numbers1": [4, 5, 6], "Numbers2": [4, 5, 6]}""";

      // Default Replace Behavior
      var objReplace = JsonSerializer.Deserialize<JsonClassDefaultReplace>(listJson);
      Console.WriteLine($"[Default Replace] Numbers1 (read-only): {string.Join(", ", objReplace!.Numbers1)}");
      Console.WriteLine($"[Default Replace] Numbers2 (read-write): {string.Join(", ", objReplace.Numbers2)}");

      // Populate Attribute Behavior
      var objPopulateAttr = JsonSerializer.Deserialize<JsonClassWithPopulateAttribute>(listJson);
      Console.WriteLine($"[Attribute Mix] Numbers1 (forced Replace): {string.Join(", ", objPopulateAttr!.Numbers1)}");
      Console.WriteLine($"[Attribute Mix] Numbers2 (inherited Populate): {string.Join(", ", objPopulateAttr.Numbers2)}");

      // Global Options PreferredObjectCreationHandling
      var populateOptions = new JsonSerializerOptions
      {
        PreferredObjectCreationHandling = JsonObjectCreationHandling.Populate
      };

      var objGlobalPopulate = JsonSerializer.Deserialize<JsonClassDefaultReplace>(listJson, populateOptions);
      Console.WriteLine($"[Global Options Populate] Numbers1: {string.Join(", ", objGlobalPopulate!.Numbers1)}");
      Console.WriteLine($"[Global Options Populate] Numbers2: {string.Join(", ", objGlobalPopulate.Numbers2)}");
      Console.WriteLine();

      // --- Section 3: Reading JSON from File ---
      Console.WriteLine("--- 3. Reading JSON from File ---");
      string filePath = "customer_chapter5.json";
      string sampleJsonFileContent = """
                {
                    "Name": "Anette Thomsen",
                    "Age": 30,
                    "Address": "123 Main St"
                }
                """;

      File.WriteAllText(filePath, sampleJsonFileContent);

      string fileText = File.ReadAllText(filePath);
      var customerFromFile = JsonSerializer.Deserialize<JsonBankCustomer>(fileText);

      if (customerFromFile != null)
      {
        Console.WriteLine($"Deserialized from '{filePath}':");
        Console.WriteLine($"Name: {customerFromFile.Name}, Age: {customerFromFile.Age}, Address: {customerFromFile.Address}");
      }

      // Cleanup sample file
      if (File.Exists(filePath))
      {
        File.Delete(filePath);
      }
    }
  }
}
