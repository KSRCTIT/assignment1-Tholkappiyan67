using System;

class Patient
{
    public string Name { get; set; }
    public DateTime DateOfAdmission { get; set; }
    public int Age { get; set; }
    public string Disease { get; set; }
    public DateTime DateOfDischarge { get; set; }
    public double TotalBillsPaid { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Disease: {Disease}, Total Bills Paid: {TotalBillsPaid:C}");
        Console.WriteLine($"Admission Date: {DateOfAdmission:MMMM d, yyyy}, Discharge Date: {DateOfDischarge:MMMM d, yyyy}");
    }
}

class Hospital
{
    static void Main()
    {
        Console.Write("Enter patient's name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter patient's age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the disease: ");
        string disease = Console.ReadLine();
        
        Console.Write("Enter date of admission (yyyy-mm-dd): ");
        DateTime dateOfAdmission = DateTime.Parse(Console.ReadLine());
        
        Console.Write("Enter date of discharge (yyyy-mm-dd): ");
        DateTime dateOfDischarge = DateTime.Parse(Console.ReadLine());
        
        Console.Write("Enter total bills paid: ");
        double totalBillsPaid = double.Parse(Console.ReadLine());

        Patient patient = new Patient
        {
            Name = name,
            Age = age,
            Disease = disease,
            DateOfAdmission = dateOfAdmission,
            DateOfDischarge = dateOfDischarge,
            TotalBillsPaid = totalBillsPaid
        };

        patient.PrintDetails();
    }
}
