using System;
using System.Threading.Tasks;

namespace AsynchronousTaskManager
{
  /// <summary>
  /// Manage Asynchronous and Parallel Tasks
  /// <br /><br />
  /// Demonstrates exception management in parallel and task execution using AggregateException,
  /// inner exception iteration, and the AggregateException.Handle predicate method.
  /// </summary>

  // Custom domain exception for error handling demonstration
  public class AsynchronousTaskException : Exception
  {
    public AsynchronousTaskException(string message) : base(message) { }
  }

  public class AsynchronousTaskProcessor
  {
    /// <summary>
    /// Demonstrates manual enumeration of InnerExceptions from an AggregateException.
    /// </summary>
    public void HandleExceptionsWithLoop()
    {
      Task task = Task.Run(() => throw new AsynchronousTaskException("Expected exception in task loop enumeration."));

      try
      {
        // Synchronously wait to observe propagated AggregateException
        task.Wait();
      }
      catch (AggregateException ae)
      {
        foreach (var ex in ae.InnerExceptions)
        {
          if (ex is AsynchronousTaskException customEx)
          {
            Console.WriteLine($"[Handled via Loop]: {customEx.Message}");
          }
          else
          {
            throw;
          }
        }
      }
    }

    /// <summary>
    /// Demonstrates predicate filtering of InnerExceptions using AggregateException.Handle.
    /// </summary>
    public void HandleExceptionsWithPredicate()
    {
      Task task = Task.Run(() => throw new AsynchronousTaskException("Expected exception in task predicate handler."));

      try
      {
        task.Wait();
      }
      catch (AggregateException ae)
      {
        // Return true if handled, false to rethrow automatically
        ae.Handle(ex =>
        {
          if (ex is AsynchronousTaskException customEx)
          {
            Console.WriteLine($"[Handled via Predicate]: {customEx.Message}");
            return true;
          }
          return false;
        });
      }
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("--- Manage Asynchronous and Parallel Tasks ---");

      var processor = new AsynchronousTaskProcessor();

      Console.WriteLine("\n[1] Handling Task Exceptions via InnerExceptions Loop:");
      processor.HandleExceptionsWithLoop();

      Console.WriteLine("\n[2] Handling Task Exceptions via AggregateException.Handle Predicate:");
      processor.HandleExceptionsWithPredicate();
    }
  }
}
