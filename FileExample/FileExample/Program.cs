using System;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
           string filePath = @"C:\Users\Brando\Desktop\Pride and Prejudice by Jane Austen.txt";

            //Reads the entire file into 1 single string
            //string contentsofFile = File.ReadAllText(filePath);

            var lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                if (currentLine.Contains("Chapter"))
                    {
                    Console.ReadKey();
                    }
            }

            //output 5 lines at a time of the file
            //for (int i = 0; i < lines.Length; i++)
            // {
            //  if (i % 5 == 0 && i != 0)
            // {
            // Console.ReadKey();
            // }

            // Console.WriteLine(lines[i]);
            // }

            //  Console.WriteLine(lines);
        }
    }
}
