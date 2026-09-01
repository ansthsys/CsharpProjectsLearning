using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace AsynchronousFileInputOutput
{
  /// <summary>
  /// Asynchronous File Input and Output
  /// <br /><br />
  /// Demonstrates how to perform asynchronous file read and write operations 
  /// using System.IO.File async methods combined with System.Text.Json serialization.
  /// </summary>

  // Model class for data persistence
  public class AsynchronousAccount
  {
    public string Name { get; set; } = string.Empty;
    public decimal Balance { get; set; }
  }

  public class AsynchronousFileService
  {
    /// <summary>
    /// Serializes an account object and writes it to a file asynchronously.
    /// </summary>
    public async Task SaveAccountDataAsync(string filePath, AsynchronousAccount account)
    {
      string jsonString = JsonSerializer.Serialize(account);
      await File.WriteAllTextAsync(filePath, jsonString);
    }

    /// <summary>
    /// Reads a JSON file asynchronously and deserializes it back into an account object.
    /// </summary>
    public async Task<AsynchronousAccount?> LoadAccountDataAsync(string filePath)
    {
      string jsonString = await File.ReadAllTextAsync(filePath);
      return JsonSerializer.Deserialize<AsynchronousAccount>(jsonString);
    }
  }

  public class Program
  {
    public static async Task Main()
    {
      Console.WriteLine("--- Asynchronous File Input and Output ---");

      // Define directory and file paths safely
      string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TempDir");
      if (!Directory.Exists(directoryPath))
      {
        Directory.CreateDirectory(directoryPath);
      }

      string filePath = Path.Combine(directoryPath, "asynchronous_account.json");
      var account = new AsynchronousAccount { Name = "Elize Harmsen", Balance = 1000.00m };
      var fileService = new AsynchronousFileService();

      // Save account data to file asynchronously
      await fileService.SaveAccountDataAsync(filePath, account);
      Console.WriteLine($"Account data successfully written asynchronously to: {filePath}");

      // Load account data from file asynchronously
      AsynchronousAccount? loadedAccount = await fileService.LoadAccountDataAsync(filePath);
      if (loadedAccount != null)
      {
        Console.WriteLine($"Loaded Account -> Name: {loadedAccount.Name}, Balance: {loadedAccount.Balance:C}");
      }

      // Cleanup created resources
      if (File.Exists(filePath))
      {
        File.Delete(filePath);
      }
      if (Directory.Exists(directoryPath))
      {
        Directory.Delete(directoryPath);
      }
    }
  }
}
