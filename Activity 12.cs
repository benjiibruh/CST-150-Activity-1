using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the path to the .txt file: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            string fileContent = File.ReadAllText(filePath);
            int wordCount = CountWordsEndingWithTE(fileContent);
            Console.WriteLine($"Number of words ending with 't' or 'e': {wordCount}");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int CountWordsEndingWithTE(string text)
    {
        string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        Regex regex = new Regex(@"[teTE]$"); // Match words ending with 't' or 'e'

        foreach (string word in words)
        {
            if (regex.IsMatch(word))
            {
                count++;
            }
        }

        return count;
    }
}

