using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> testing = new List<Shape>();

        testing.Add(new Square("Blue", 10.5));
        testing.Add(new Rectangle("Red", 5.5, 7.5));
        testing.Add(new Circle("Green", 2.5));

        foreach (Shape read in testing)
        {
            Console.WriteLine($"{read.getColor()} {read.GetType()} has Area of {read.getArea()}");
        }
    }
}