using System;

class Program
{
    const double UnderWeightMax = 11;
    const double NormalWeightMax = 13;
    const double OverWeightMax = 15;

    static void Main()
    {
        Console.WriteLine("Enter mass in kg:");
        double mass = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height in m:");
        double height = double.Parse(Console.ReadLine());

        double ciValue = ci(mass, height);
        string category;

        // --- IF/ELSE VERSION ---
        /*
        if (ciValue < UnderWeightMax)
            category = "underweight";
        else if (ciValue < NormalWeightMax)
            category = "normal weight";
        else if (ciValue < OverWeightMax)
            category = "overweight";
        else
            category = "obese";
        */

        // --- SWITCH VERSION ---
        switch (ciValue)
        {
            case < UnderWeightMax:
                category = "underweight"; break;
            case < NormalWeightMax:
                category = "normal weight"; break;
            case < OverWeightMax:
                category = "overweight"; break;
            default:
                category = "obese"; break;
        }

        Console.WriteLine($"Adults corpulence index of {ciValue:F2} means: {category}");
    }

    static double ci(double mass, double height)
    {
        return mass / Math.Pow(height, 2);
    }
}