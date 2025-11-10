using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Is the lecture topic interesting? (y/n)");
        bool interesting = Console.ReadLine().ToLower() == "y";

        Console.WriteLine("Does one of your friends join? (y/n)");
        bool friend = Console.ReadLine().ToLower() == "y";

        Console.WriteLine("Do you have problems with the assignment? (y/n)");
        bool problem = Console.ReadLine().ToLower() == "y";

        if (interesting && (friend || problem))
            Console.WriteLine("Go. ✅");
        else
            Console.WriteLine("Stay. ❌");
    }
}