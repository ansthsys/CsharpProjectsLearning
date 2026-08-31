using System;
using System.IO;

/// <summary>
/// Directory, File, and Path Class Operations
/// <br /><br />
/// Demonstrates how to manage local directories and files using the static Path,
/// Directory, and File classes provided in the System.IO namespace.
/// </summary>
namespace FileIODirectoryFilePath
{
    class Program
    {
        static void Main()
        {
            // 1. Path Class Operations
            string directoryPath = @"C:\ExampleDirectory";
            string fileName = "example.txt";

            // Combine directory and file name to create a full path
            string fullPath = Path.Combine(directoryPath, fileName);
            Console.WriteLine("Full Path: " + fullPath);

            // Get the file name without extension
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullPath);
            Console.WriteLine("File Name Without Extension: " + fileNameWithoutExtension);

            // Get the file extension
            string fileExtension = Path.GetExtension(fullPath);
            Console.WriteLine("File Extension: " + fileExtension);

            // 2. Directory Class Operations
            // Create a new directory
            Directory.CreateDirectory(directoryPath);

            // Check if the directory exists
            if (Directory.Exists(directoryPath))
            {
                Console.WriteLine("Directory exists.");
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }

            // 3. File Class Operations
            string filePath = @"C:\ExampleFile.txt";

            // Create a new file and write text to it
            File.WriteAllText(filePath, "Hello, World!");

            // Read the text from the file
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);

            // 4. Combined Directory, File, and Path Operations
            string combinedDirectory = @"C:\ExampleDirectoryCombined";
            string combinedFileName = "combined_example.txt";
            string combinedFilePath = Path.Combine(combinedDirectory, combinedFileName);

            // Create directory using Directory class
            Directory.CreateDirectory(combinedDirectory);

            // Create and write to file using File class
            File.WriteAllText(combinedFilePath, "Hello from combined operations!");

            // Read back from file
            string combinedText = File.ReadAllText(combinedFilePath);
            Console.WriteLine("Combined Result: " + combinedText);

            // Enumerate files inside the directory
            if (Directory.Exists(combinedDirectory))
            {
                foreach (string file in Directory.EnumerateFiles(combinedDirectory))
                {
                    Console.WriteLine("Enumerated File: " + file);
                }
            }
        }
    }
}
