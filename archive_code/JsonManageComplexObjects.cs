using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonManageComplexObjects
{
  /// <summary>
  /// Manage Serialization and Deserialization of Complex Objects
  /// <br /><br />
  /// Demonstrates handling circular references using JsonSerializerOptions.ReferenceHandler.Preserve
  /// and simplifying complex structures using Data Transfer Objects (DTOs).
  /// </summary>

  // 1. Models for Circular Reference Demonstration
  public class JsonPersonWithPet
  {
    public string Name { get; set; } = string.Empty;
    public List<JsonPet> Pets { get; set; } = new();
  }

  public class JsonPet
  {
    public string Name { get; set; } = string.Empty;
    public JsonPersonWithPet? Owner { get; set; }
  }

  // 2. Complex Domain Models for DTO Demonstration
  public class JsonPersonDetail
  {
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
  }

  public class JsonEmployee
  {
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int EmployeeId { get; set; }
    public double Salary { get; set; }
    public List<JsonPersonDetail> Dependents { get; set; } = new();
    public List<JsonPersonDetail> EmergencyContacts { get; set; } = new();
  }

  public class JsonCompany
  {
    public string Name { get; set; } = "Contoso Ltd";
    public List<JsonEmployee> Employees { get; set; } = new();

    public JsonCompany(JsonEmployee employee)
    {
      Employees.Add(employee);
    }
  }

  // 3. Simplified Data Transfer Object (DTO)
  public class JsonEmployeeDTO
  {
    public string Name { get; set; } = string.Empty;
    public int EmployeeId { get; set; }
  }

  public class Program
  {
    public static void Main()
    {
      // --- Section 1: Handling Circular References ---
      Console.WriteLine("--- 1. Circular Reference Handling (ReferenceHandler.Preserve) ---");

      var owner = new JsonPersonWithPet { Name = "John" };
      var pet1 = new JsonPet { Name = "Fido", Owner = owner };
      var pet2 = new JsonPet { Name = "Whiskers", Owner = owner };
      owner.Pets.AddRange(new[] { pet1, pet2 });

      var preserveOptions = new JsonSerializerOptions
      {
        ReferenceHandler = ReferenceHandler.Preserve,
        WriteIndented = true
      };

      // Serialize circular graph
      string circularJson = JsonSerializer.Serialize(owner, preserveOptions);
      Console.WriteLine("Serialized JSON with $id and $ref:");
      Console.WriteLine(circularJson);
      Console.WriteLine();

      // Deserialize back to object graph
      var deserializedOwner = JsonSerializer.Deserialize<JsonPersonWithPet>(circularJson, preserveOptions);
      Console.WriteLine($"Deserialized Owner: {deserializedOwner?.Name}");
      if (deserializedOwner != null)
      {
        foreach (var pet in deserializedOwner.Pets)
        {
          Console.WriteLine($"  Pet Name: {pet.Name}, Owner: {pet.Owner?.Name}");
        }
      }
      Console.WriteLine();

      // --- Section 2: Using Data Transfer Objects (DTOs) ---
      Console.WriteLine("--- 2. Data Transfer Objects (DTOs) for Selective Serialization ---");

      var employee = new JsonEmployee
      {
        Name = "Elize Harmsen",
        Age = 35,
        Gender = "Female",
        Address = "123 Main St",
        Email = "elize@example.com",
        EmployeeId = 101,
        Salary = 75000,
        Dependents = new List<JsonPersonDetail>
                {
                    new JsonPersonDetail { Name = "Peter Zammit", Age = 35 }
                },
        EmergencyContacts = new List<JsonPersonDetail>
                {
                    new JsonPersonDetail { Name = "Anette Thomsen", Age = 40 }
                }
      };

      var company = new JsonCompany(employee);

      // Step 1: Map Domain Model to DTO
      var employeeDTO = new JsonEmployeeDTO
      {
        Name = employee.Name,
        EmployeeId = employee.EmployeeId
      };

      // Step 2: Serialize DTO
      string dtoJson = JsonSerializer.Serialize(employeeDTO);
      Console.WriteLine("Serialized EmployeeDTO:");
      Console.WriteLine(dtoJson);
      Console.WriteLine();

      // Step 3: Deserialize JSON back to DTO
      var deserializedDTO = JsonSerializer.Deserialize<JsonEmployeeDTO>(dtoJson);

      // Step 4: Map DTO back to lightweight entity for lookup
      if (deserializedDTO != null)
      {
        var searchTarget = new JsonEmployee
        {
          Name = deserializedDTO.Name,
          EmployeeId = deserializedDTO.EmployeeId
        };

        // Step 5: Resolve original entity from store/company
        var foundEmployee = company.Employees.Find(e => e.EmployeeId == searchTarget.EmployeeId);
        if (foundEmployee != null)
        {
          Console.WriteLine("Found Employee Details from Domain Store:");
          Console.WriteLine($"  ID: {foundEmployee.EmployeeId}");
          Console.WriteLine($"  Name: {foundEmployee.Name}");
          Console.WriteLine($"  Age: {foundEmployee.Age}");
          Console.WriteLine($"  Gender: {foundEmployee.Gender}");
          Console.WriteLine($"  Email: {foundEmployee.Email}");
          Console.WriteLine($"  Salary: {foundEmployee.Salary}");
          Console.WriteLine($"  Dependents: {string.Join(", ", foundEmployee.Dependents.Select(d => d.Name))}");
          Console.WriteLine($"  Emergency Contacts: {string.Join(", ", foundEmployee.EmergencyContacts.Select(ec => ec.Name))}");
        }
        else
        {
          Console.WriteLine("Employee not found in the company.");
        }
      }
    }
  }
}
