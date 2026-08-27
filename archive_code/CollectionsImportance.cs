using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Importance of Collections
/// <br /><br />
/// Demonstrates how C# collections manage groups of strongly typed objects,
/// including ordered collections with List&lt;T&gt;, unique collections with
/// HashSet&lt;T&gt;, and key-value collections with Dictionary&lt;TKey, TValue&gt;.
/// </summary>
namespace CollectionsImportance
{
  /// <summary>
  /// Represents a bank account used to demonstrate a Dictionary collection.
  /// </summary>
  public class Account
  {
    public int CustomerId { get; set; }
    public string AccountNumber { get; set; } = string.Empty;
    public decimal Balance { get; set; }
  }

  /// <summary>
  /// Represents a transaction used to demonstrate an ordered List collection.
  /// </summary>
  public class Transaction
  {
    public int Id { get; set; }
    public decimal Amount { get; set; }
  }

  internal class Program
  {
    static void Main()
    {
      // Collections are strongly typed.
      List<string> names = new List<string>
            {
                "Alice",
                "Bob",
                "Charlie"
            };

      names.Add("David");
      names.Remove("Bob");

      Console.WriteLine("List<T>:");
      foreach (string name in names)
      {
        Console.WriteLine(name);
      }

      // Collections can be accessed by index.
      Console.WriteLine($"First name: {names[0]}");

      // Collections can be enumerated and queried with LINQ.
      List<Transaction> transactions = new List<Transaction>
            {
                new Transaction { Id = 1, Amount = 150 },
                new Transaction { Id = 2, Amount = 500 },
                new Transaction { Id = 3, Amount = 75 }
            };

      List<Transaction> largeTransactions = transactions
          .Where(transaction => transaction.Amount >= 100)
          .ToList();

      Console.WriteLine("\nFiltered transactions:");
      foreach (Transaction transaction in largeTransactions)
      {
        Console.WriteLine(
            $"Transaction {transaction.Id}: {transaction.Amount}"
        );
      }

      // HashSet<T> stores unique elements.
      HashSet<int> customerIds = new HashSet<int>
            {
                1001,
                1002,
                1003
            };

      customerIds.Add(1002);
      customerIds.Add(1004);

      Console.WriteLine("\nHashSet<T>:");
      foreach (int customerId in customerIds)
      {
        Console.WriteLine(customerId);
      }

      // Dictionary<TKey, TValue> stores key/value pairs.
      Dictionary<int, Account> accounts =
          new Dictionary<int, Account>
          {
                    {
                        1001,
                        new Account
                        {
                            CustomerId = 1001,
                            AccountNumber = "ACC-001",
                            Balance = 2500
                        }
                    },
                    {
                        1002,
                        new Account
                        {
                            CustomerId = 1002,
                            AccountNumber = "ACC-002",
                            Balance = 5000
                        }
                    }
          };

      // Quick lookup using the customer's unique key.
      if (accounts.TryGetValue(1001, out Account? account))
      {
        Console.WriteLine("\nDictionary<TKey, TValue>:");
        Console.WriteLine(
            $"Customer {account.CustomerId}: " +
            $"{account.AccountNumber}, " +
            $"Balance = {account.Balance}"
        );
      }

      // Collections can be copied to arrays.
      string[] nameArray = names.ToArray();

      Console.WriteLine("\nCopied to array:");
      foreach (string name in nameArray)
      {
        Console.WriteLine(name);
      }
    }
  }
}