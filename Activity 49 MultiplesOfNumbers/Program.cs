using System;  // # Giver adgang til Console (input/output)

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");   // # Beder brugeren om at skrive et heltal
        string input = Console.ReadLine();        // # Læser hele tallet som tekst

        int sum = 0;                              // # Starter en variabel til at holde summen af cifrene

        // # For hver karakter (tegn) i den indtastede tekst:
        foreach (char c in input)
        {
            // # Forsøger at omdanne tegnet til et tal (hvis det fx er '1', bliver det til 1)
            if (int.TryParse(c.ToString(), out int digit))
            {
                sum += digit;                     // # Lægger tallet til summen
            }
        }

        Console.WriteLine($"Sum: {sum}");         // # Skriver den samlede sum ud til brugeren
    }
}