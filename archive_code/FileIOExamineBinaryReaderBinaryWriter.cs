using System;
using System.IO;
using System.Text;

namespace FileIO
{
    /// <summary>
    /// Examine the BinaryReader and BinaryWriter Classes
    /// <br /><br />
    /// Demonstrates how to read and write primitive data types in binary format 
    /// using BinaryWriter and BinaryReader classes, including explicit Encoding configuration
    /// and underlying FileStream integration.
    /// </summary>
    public class FileIOExamineBinaryReaderBinaryWriter
    {
        public static void Main()
        {
            string filePath = "example.dat";

            // 1. Basic Binary Data Writing
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(42);           // Integer
                    writer.Write(3.14);         // Double
                    writer.Write("Hello, World!"); // String
                }
            }

            // 2. Basic Binary Data Reading
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    int intValue = reader.ReadInt32();
                    double doubleValue = reader.ReadDouble();
                    string stringValue = reader.ReadString();

                    Console.WriteLine($"Integer: {intValue}");
                    Console.WriteLine($"Double: {doubleValue}");
                    Console.WriteLine($"String: {stringValue}");
                }
            }

            // 3. Binary Data Operations with Explicit Encoding (UTF-8)
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8))
                {
                    writer.Write(100);
                    writer.Write(2.718);
                    writer.Write("Binary Data with UTF8 Encoding");
                }
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs, Encoding.UTF8))
                {
                    int intValue = reader.ReadInt32();
                    double doubleValue = reader.ReadDouble();
                    string stringValue = reader.ReadString();

                    Console.WriteLine($"Encoded Integer: {intValue}");
                    Console.WriteLine($"Encoded Double: {doubleValue}");
                    Console.WriteLine($"Encoded String: {stringValue}");
                }
            }
        }
    }
}
