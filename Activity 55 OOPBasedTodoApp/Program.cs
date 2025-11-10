using System;
using System.Collections.Generic;  // # Giver adgang til List

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();  // # Liste til at gemme ordene

        Console.WriteLine("Enter words of a sentence one by one including punctuation:");
        Console.WriteLine("(Press Enter on an empty line to finish)\n");

        while (true)
        {
            string word = Console.ReadLine();     // # Læser et ord
            if (string.IsNullOrWhiteSpace(word))  // # Stopper når linjen er tom
                break;

            words.Add(word);                      // # Tilføjer ordet til listen
        }

        string sentence = string.Join(" ", words);  // # Samler alle ord med mellemrum
        Console.WriteLine(sentence);                // # Skriver hele sætningen ud
    }
}