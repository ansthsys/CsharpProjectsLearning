using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// StreamReader and StreamWriter Text File Operations
/// <br /><br />
/// Demonstrates reading and writing text files, processing CSV data,
/// and mapping between CSV strings and C# objects using StreamReader,
/// StreamWriter, and StringBuilder.
/// </summary>
namespace FileIOStreamReaderStreamWriter
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }

        public override string ToString()
        {
            return $"{Name},{Age},{Occupation}";
        }
    }

    class Program
    {
        static void Main()
        {
            string filePath = "data_with_header.csv";

            // 1. Write initial employee data with a header using StreamWriter
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Elize Harmsen", Age = 30, Occupation = "Engineer" },
                new Employee { Name = "Peter Zammit", Age = 25, Occupation = "Designer" },
                new Employee { Name = "Niki Demetriou", Age = 35, Occupation = "Manager" }
            };

            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Name,Age,Occupation"); // Header row

                foreach (var employee in employees)
                {
                    sb.AppendLine(employee.ToString());
                }

                writer.Write(sb.ToString());
            }

            Console.WriteLine($"CSV file created at: {filePath}");

            // 2. Append additional employee data without writing header again
            List<Employee> additionalEmployees = new List<Employee>
            {
                new Employee { Name = "Hannah Haynes", Age = 28, Occupation = "Developer" },
                new Employee { Name = "Conrad Nuber", Age = 32, Occupation = "Analyst" }
            };

            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();

                foreach (var employee in additionalEmployees)
                {
                    sb.AppendLine(employee.ToString());
                }

                writer.Write(sb.ToString());
            }

            // 3. Read the CSV file line by line and reconstruct Employee objects using StreamReader
            List<Employee> readEmployees = new List<Employee>();

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string headerLine = reader.ReadLine();
                Console.WriteLine($"Header: {headerLine}");

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    Employee employee = new Employee
                    {
                        Name = data[0],
                        Age = int.Parse(data[1]),
                        Occupation = data[2]
                    };
                    readEmployees.Add(employee);
                }
            }

            // 4. Output the reconstructed objects
            Console.WriteLine("\nParsed Employee Objects:");
            foreach (var employee in readEmployees)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Occupation: {employee.Occupation}");
            }
        }
    }
}
