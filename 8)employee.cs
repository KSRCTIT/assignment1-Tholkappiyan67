using System;

class Employee
{
    public int JobCategory { get; set; }
    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public double BasicSalary { get; set; }
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Loan { get; set; }
    public double PF { get; set; }

    public Employee(int jobCategory)
    {
        JobCategory = jobCategory;
        SetSalaryComponents();
    }

    private void SetSalaryComponents()
    {
        if (JobCategory == 1)
        {
            BasicSalary = 8000;
            HRA = 0.1 * BasicSalary;
            DA = 0.2 * BasicSalary;
            Loan = 300;
            PF = 500;
        }
        else if (JobCategory == 2)
        {
            BasicSalary = 15000;
            HRA = 0.2 * BasicSalary;
            DA = 0.3 * BasicSalary;
            Loan = 600;
            PF = 1000;
        }
        else
        {
            throw new ArgumentException("Invalid job category. Must be 1 or 2.");
        }
    }

    public void InputDetails(int empNo, string empName)
    {
        EmpNo = empNo;
        EmpName = empName;
    }

    public double CalculateSalary()
    {
        return BasicSalary + HRA + DA - (Loan + PF);
    }

    public void Display()
    {
        Console.WriteLine($"Employee No: {EmpNo}");
        Console.WriteLine($"Employee Name: {EmpName}");
        Console.WriteLine($"Job Category: {JobCategory}");
        Console.WriteLine($"Basic Salary: {BasicSalary:C}");
        Console.WriteLine($"HRA: {HRA:C}");
        Console.WriteLine($"DA: {DA:C}");
        Console.WriteLine($"Loan Deduction: {Loan:C}");
        Console.WriteLine($"PF Deduction: {PF:C}");
        Console.WriteLine($"Net Salary: {CalculateSalary():C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int jobCategory;
        while (true)
        {
            Console.Write("Enter Job Category (1 or 2): ");
            if (int.TryParse(Console.ReadLine(), out jobCategory) && (jobCategory == 1 || jobCategory == 2))
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter 1 or 2.");
        }

        Employee emp = new Employee(jobCategory);

        int empNo;
        while (true)
        {
            Console.Write("Enter Employee Number: ");
            if (int.TryParse(Console.ReadLine(), out empNo))
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.Write("Enter Employee Name: ");
        string empName = Console.ReadLine();

        emp.InputDetails(empNo, empName);
        emp.Display();
    }
}
