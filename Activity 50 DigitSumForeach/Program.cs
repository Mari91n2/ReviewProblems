using System;          // # Giver adgang til Console (input/output)
using System.Collections.Generic;  // # Giver adgang til List-klassen

class Program
{
    static void Main()
    {
        // # Opretter en liste til at gemme de enkelte ord
        List<string> words = new List<string>();

        Console.WriteLine("Enter words of a sentence one by one including punctuation:"); 
        Console.WriteLine("(Press Enter on an empty line to finish)\n");

        string word;

        // # Læser ord fra brugeren indtil de stopper (tom linje)
        while (true)
        {
            word = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(word))  // # Stopper når brugeren trykker Enter uden at skrive noget
                break;

            words.Add(word);                      // # Tilføjer ordet til listen
        }

        // # Samler alle ordene til én sætning adskilt med mellemrum
        string sentence = string.Join(" ", words);

        // # Skriver hele sætningen ud
        Console.WriteLine(sentence);
    }
}