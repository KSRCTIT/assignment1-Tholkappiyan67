using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

    public void PrintPerson()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight}");
    }
}

class PersonData
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Kannan,
            Age = 19,
            Weight = 65.5
        };

        person.PrintPerson();
    }
}
