using System;

class Vector
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Vector operator +(Vector a, Vector b)
    {
        return new Vector(a.X + b.X, a.Y + b.Y);
    }

    public void Display()
    {
        Console.WriteLine($"Vector: ({X}, {Y})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(1, 2);
        Vector v2 = new Vector(3, 4);
        Vector v3 = v1 + v2;
        v3.Display();
    }
}