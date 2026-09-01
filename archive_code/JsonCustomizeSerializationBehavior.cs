using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonCustomizeSerializationBehavior
{
  /// <summary>
  /// Customize Serialization Behavior
  /// <br /><br />
  /// Demonstrates how to control JSON serialization behavior using JsonSerializerOptions,
  /// JsonIgnore attributes, handling read-only properties, default/null value exclusion,
  /// including fields with JsonInclude, and writing JSON output to files.
  /// </summary>

  // 1. Class demonstrating [JsonIgnore] attribute and custom conditions
  public class JsonWeatherForecastWithIgnoreAttribute
  {
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }

    [JsonIgnore]
    public string? Summary { get; set; }
  }

  public class JsonForecastWithConditions
  {
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime Date { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public int TemperatureC { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Summary { get; set; }
  }

  // 2. Class demonstrating read-only property handling
  public class JsonWeatherForecastWithROProperty
  {
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
    public int WindSpeedReadOnly { get; private set; } = 35;
  }

  // 3. Classes demonstrating inclusion of fields
  public class JsonForecastFields
  {
    public DateTime Date;
    public int TemperatureC;
    public string? Summary;
  }

  public class JsonForecastFieldsWithAttribute
  {
    [JsonInclude]
    public DateTime Date;

    [JsonInclude]
    public int TemperatureC;

    [JsonInclude]
    public string? Summary;
  }

  // 4. Model class for file writing demonstration
  public class JsonBankCustomer
  {
    public string Name { get; set; } = "John Doe";
    public decimal AccountBalance { get; set; } = 1500.75m;
  }

  public class Program
  {
    public static void Main()
    {
      // --- Section 1: Ignoring Individual Properties ---
      Console.WriteLine("--- 1. Ignore Individual Properties ---");
      var forecast = new JsonWeatherForecastWithIgnoreAttribute
      {
        Date = DateTimeOffset.Now,
        TemperatureCelsius = 25,
        Summary = "Warm"
      };

      string jsonIgnoreResult = JsonSerializer.Serialize(forecast);
      Console.WriteLine(jsonIgnoreResult);
      Console.WriteLine();

      // --- Section 2: Ignore Read-Only Properties ---
      Console.WriteLine("--- 2. Ignore Read-Only Properties ---");
      var weatherForecastRO = new JsonWeatherForecastWithROProperty
      {
        Date = DateTimeOffset.Now,
        TemperatureCelsius = 25,
        Summary = "Hot"
      };

      var roOptions = new JsonSerializerOptions
      {
        IgnoreReadOnlyProperties = true,
        WriteIndented = true
      };

      string jsonROResult = JsonSerializer.Serialize(weatherForecastRO, roOptions);
      Console.WriteLine(jsonROResult);
      Console.WriteLine();

      // --- Section 3: Ignore Null or Default Values Globally ---
      Console.WriteLine("--- 3. Ignore Default/Null Values Globally ---");
      var forecastDefault = new JsonForecastWithConditions
      {
        Date = default,
        Summary = null,
        TemperatureC = default
      };

      var defaultOptions = new JsonSerializerOptions
      {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
      };

      string jsonDefaultResult = JsonSerializer.Serialize(forecastDefault, defaultOptions);
      Console.WriteLine(jsonDefaultResult);
      Console.WriteLine();

      // --- Section 4: Include Fields During Serialization ---
      Console.WriteLine("--- 4. Include Fields ---");
      string fieldInputJson = """
                {
                    "Date":"2020-09-06T11:31:01.923395",
                    "TemperatureC":-1,
                    "Summary":"Cold"
                }
                """;

      var fieldOptions = new JsonSerializerOptions
      {
        IncludeFields = true
      };

      JsonForecastFields forecastFields = JsonSerializer.Deserialize<JsonForecastFields>(fieldInputJson, fieldOptions)!;
      string roundTrippedJson = JsonSerializer.Serialize(forecastFields, fieldOptions);
      Console.WriteLine($"Global Option Result: {roundTrippedJson}");

      JsonForecastFieldsWithAttribute forecastFieldsAttr = JsonSerializer.Deserialize<JsonForecastFieldsWithAttribute>(fieldInputJson)!;
      string attrResult = JsonSerializer.Serialize(forecastFieldsAttr);
      Console.WriteLine($"[JsonInclude] Attribute Result: {attrResult}");
      Console.WriteLine();

      // --- Section 5: Writing JSON to File ---
      Console.WriteLine("--- 5. Writing JSON to File ---");
      var customer = new JsonBankCustomer();
      string customerJson = JsonSerializer.Serialize(customer, new JsonSerializerOptions { WriteIndented = true });

      string filePath = "customer.json";
      File.WriteAllText(filePath, customerJson);
      Console.WriteLine($"JSON file created and saved to '{filePath}'.");
    }
  }
}
