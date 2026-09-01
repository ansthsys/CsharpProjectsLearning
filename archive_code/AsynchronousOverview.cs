using System;
using System.IO;
using System.Threading.Tasks;

namespace AsynchronousOverview
{
  /// <summary>
  /// Asynchronous Programming Overview
  /// <br /><br />
  /// Demonstrates the fundamentals of asynchronous programming in C# using the
  /// async and await keywords along with Task and Task&lt;TResult&gt; return types.
  /// </summary>
  public class AsynchronousFileReader
  {
    /// <summary>
    /// Reads the content of a text file asynchronously without blocking the calling thread.
    /// </summary>
    /// <param name="filePath">The path to the file to read.</param>
    /// <returns>A task that represents the asynchronous operation, containing the text content.</returns>
    public async Task<string> ReadFileAsync(string filePath)
    {
      using (StreamReader reader = new StreamReader(filePath))
      {
        string content = await reader.ReadToEndAsync();
        return content;
      }
    }
  }

  public class Program
  {
    public static async Task Main()
    {
      Console.WriteLine("--- Asynchronous Programming Overview ---");

      string samplePath = "AsynchronousSample.txt";
      string sampleText = "Hello from Asynchronous C# Programming!";

      // Setup a temporary file for reading
      await File.WriteAllTextAsync(samplePath, sampleText);

      var fileReader = new AsynchronousFileReader();

      // Execute non-blocking asynchronous file read
      string content = await fileReader.ReadFileAsync(samplePath);
      Console.WriteLine($"Read File Content Asynchronously: {content}");

      // Cleanup sample file
      if (File.Exists(samplePath))
      {
        File.Delete(samplePath);
      }
    }
  }
}
