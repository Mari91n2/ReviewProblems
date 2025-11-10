using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first integer:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second integer:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Result:");
        Console.WriteLine(a + b);  // Sum
        Console.WriteLine(a * b);  // Product
        Console.WriteLine(a - b);  // Difference
        Console.WriteLine(a / b);  // Quotient
        Console.WriteLine(a % b);  // Remainder
    }
}