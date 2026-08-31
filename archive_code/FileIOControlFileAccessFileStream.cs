using System;
using System.IO;

namespace FileIO
{
    /// <summary>
    /// Control File Access Using the FileStream Class
    /// <br /><br />
    /// Demonstrates granular file I/O operations using the FileStream class in .NET,
    /// including reading, writing, seeking, access control configurations (FileMode,
    /// FileAccess, FileShare), and exception handling with IOException.
    /// </summary>
    public class FileIOControlFileAccessFileStream
    {
        public static void Main()
        {
            string path = "example.txt";
            byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!");

            try
            {
                // Writing to the file using granular access control parameters
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 4096, false))
                {
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                    Console.WriteLine("Data written to file.");
                }

                // Reading from the file and seeking back to the beginning
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 4096, false))
                {
                    byte[] buffer = new byte[data.Length];

                    // Move position to the beginning of the file stream
                    fs.Seek(0, SeekOrigin.Begin);

                    int bytesRead = fs.Read(buffer, 0, buffer.Length);
                    string readData = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    Console.WriteLine("Data read from file: " + readData);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
