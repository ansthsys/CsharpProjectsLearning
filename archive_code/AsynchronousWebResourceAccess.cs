using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AsynchronousWebResourceAccess
{
  /// <summary>
  /// Access Web Resources Asynchronously
  /// <br /><br />
  /// Demonstrates non-blocking REST API integration using HttpClient, handling 
  /// HTTP status verification, and deserializing JSON payloads into generic models.
  /// </summary>

  // Nested DTO Models matching PetStore API JSON payload
  public class AsynchronousCategory
  {
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
  }

  public class AsynchronousTag
  {
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
  }

  public class AsynchronousPet
  {
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public AsynchronousCategory? Category { get; set; }
    public List<string> PhotoUrls { get; set; } = new();
    public List<AsynchronousTag> Tags { get; set; } = new();
    public string Status { get; set; } = string.Empty;
  }

  public class AsynchronousPetStoreService
  {
    private readonly HttpClient _httpClient;

    public AsynchronousPetStoreService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    /// <summary>
    /// Fetches available pets from remote REST API asynchronously.
    /// </summary>
    public async Task<List<AsynchronousPet>> GetAvailablePetsAsync()
    {
      string url = "https://petstore.swagger.io/v2/pet/findByStatus?status=available";

      HttpResponseMessage response = await _httpClient.GetAsync(url);
      response.EnsureSuccessStatusCode();

      string jsonBody = await response.Content.ReadAsStringAsync();

      var options = new JsonSerializerOptions
      {
        PropertyNameCaseInsensitive = true
      };

      return JsonSerializer.Deserialize<List<AsynchronousPet>>(jsonBody, options) ?? new List<AsynchronousPet>();
    }
  }

  public class Program
  {
    public static async Task Main()
    {
      Console.WriteLine("--- Access Web Resources Asynchronously ---");

      // Safe disposal of HTTP Client resources via using block
      using (HttpClient httpClient = new HttpClient())
      {
        var petService = new AsynchronousPetStoreService(httpClient);

        try
        {
          Console.WriteLine("Fetching pets asynchronously from API...");
          List<AsynchronousPet> pets = await petService.GetAvailablePetsAsync();

          Console.WriteLine($"Successfully retrieved {pets.Count} available pets.");
          Console.WriteLine("Filtered Results (Pet ID length > 4):");

          int displayCount = 0;
          foreach (var pet in pets)
          {
            if (pet.Id.ToString().Length > 4)
            {
              Console.WriteLine($"  Pet ID: {pet.Id}, Name: {pet.Name}");
              displayCount++;
            }

            // Limit output display for readability
            if (displayCount >= 5) break;
          }
        }
        catch (HttpRequestException ex)
        {
          Console.WriteLine($"[HTTP Request Failure]: {ex.Message}");
        }
        catch (JsonException ex)
        {
          Console.WriteLine($"[JSON Parsing Error]: {ex.Message}");
        }
      }
    }
  }
}
