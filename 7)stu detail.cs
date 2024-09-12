using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string MobileNumber { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Address: {Address}, Mobile Number: {MobileNumber}";
    }
}

class StudentMark : Student
{
    public int Marks { get; set; }

    public override string ToString()
    {
        char grade = CalculateGrade();
        return $"{base.ToString()}, Marks: {Marks}, Grade: {grade}";
    }

    public char CalculateGrade()
    {
        if (Marks >= 90) return 'A';
        if (Marks >= 75) return 'B';
        if (Marks >= 50) return 'C';
        return 'F';
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentMark student = new StudentMark();

        Console.Write("Enter student's name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter student's age: ");
        student.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter student's address: ");
        student.Address = Console.ReadLine();

        Console.Write("Enter student's mobile number: ");
        student.MobileNumber = Console.ReadLine();

        Console.Write("Enter student's marks: ");
        student.Marks = int.Parse(Console.ReadLine());

        Console.WriteLine("\nStudent Information:");
        Console.WriteLine(student.ToString());
    }
}
