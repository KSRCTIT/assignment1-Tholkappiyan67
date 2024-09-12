using System;

class EligibilityCheck
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Invalid input for age. Please enter a valid number.");
            return;
        }

        Console.Write("Enter your pass percentage: ");
        if (!double.TryParse(Console.ReadLine(), out double passPercentage))
        {
            Console.WriteLine("Invalid input for pass percentage. Please enter a valid number.");
            return;
        }

        if (age > 18 && age <= 30 && passPercentage >= 65)
        {
            Console.WriteLine("You are eligible.");
        }
        else
        {
            Console.WriteLine("You are not eligible.");
        }
    }
}
