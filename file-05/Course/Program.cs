using System;
using System.Collections.Generic;
using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", System.IO.SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach (string fold in folders)
                {
                    Console.WriteLine(fold);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", System.IO.SearchOption.AllDirectories);

                Console.WriteLine("FILES:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}