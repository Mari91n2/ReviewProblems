using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();
        Console.WriteLine("Enter words of a sentence one by one including punctuation:");
        string word;

        while (true)
        {
            word = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(word)) break;
            words.Add(word);
        }

        Console.WriteLine(string.Join(" ", words));
    }
}