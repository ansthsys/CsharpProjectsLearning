using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousParallelExecution
{
  /// <summary>
  /// Run Asynchronous Tasks in Parallel
  /// <br /><br />
  /// Demonstrates I/O concurrency via Task.WhenAll (Promise.all equivalent) 
  /// and CPU-bound data parallelism using Parallel.ForEach with thread-safe collections.
  /// </summary>
  public class AsynchronousParallelProcessor
  {
    private readonly HttpClient _httpClient;

    public AsynchronousParallelProcessor(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    /// <summary>
    /// Equivalent to Promise.all in JS: Executes multiple asynchronous HTTP GET calls concurrently.
    /// </summary>
    public async Task<string[]> FetchDataInParallelAsync(IEnumerable<string> urls)
    {
      var tasks = new List<Task<string>>();
      foreach (var url in urls)
      {
        tasks.Add(_httpClient.GetStringAsync(url));
      }

      // Awaits all tasks to complete and gathers results into an array
      return await Task.WhenAll(tasks);
    }

    /// <summary>
    /// Multi-threaded CPU processing across available core threads using ConcurrentBag for thread-safety.
    /// </summary>
    public ConcurrentBag<string> ProcessItemsInParallel(IEnumerable<int> numbers)
    {
      var processedBag = new ConcurrentBag<string>();

      // Distributes iterations across available CPU cores
      Parallel.ForEach(numbers, number =>
      {
        // Simulate CPU-intensive work
        string result = $"Processed Item: {number * 2}";
        processedBag.Add(result);
      });

      return processedBag;
    }
  }

  public class Program
  {
    public static async Task Main()
    {
      Console.WriteLine("--- Run Asynchronous Tasks in Parallel ---");

      using (HttpClient client = new HttpClient())
      {
        var processor = new AsynchronousParallelProcessor(client);

        // 1. Task.WhenAll (I/O Parallelism - Promise.all)
        Console.WriteLine("\n1. Fetching Web Resources (Task.WhenAll):");
        var urls = new[] { "https://httpbin.org/get", "https://httpbin.org/ip" };

        try
        {
          string[] responses = await processor.FetchDataInParallelAsync(urls);
          Console.WriteLine($"Successfully fetched {responses.Length} endpoints concurrently.");
        }
        catch (HttpRequestException ex)
        {
          Console.WriteLine($"[HTTP Error]: {ex.Message}");
        }

        // 2. Parallel.ForEach (CPU Data Parallelism - Thread Pooling)
        Console.WriteLine("\n2. Processing CPU Workload (Parallel.ForEach):");
        var dataset = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        ConcurrentBag<string> results = processor.ProcessItemsInParallel(dataset);

        Console.WriteLine($"Total processed items in ConcurrentBag: {results.Count}");
      }
    }
  }
}
