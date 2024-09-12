using System;
using System.Text.RegularExpressions;

class Validation
{
    static void Main()
    {
        Console.Write("Enter mobile number: ");
        string mobileNumber = Console.ReadLine();

        // Validate the mobile number format
        if (Regex.IsMatch(mobileNumber, @"^[98]\d{3}-\d{6}$"))
        {
            Console.WriteLine("Valid mobile number");
        }
        else
        {
            Console.WriteLine("Invalid mobile number");
        }
    }
}