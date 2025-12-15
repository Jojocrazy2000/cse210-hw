using System.Runtime.CompilerServices;

public abstract class Plan
{
    // Variables
    protected String _description;
    protected String _day;

    // Constructor
    public Plan(string description, string day)
    {
        _description = description;
        _day = day;
    }

    public Plan() // For the specific use casses
    {
        // Give description of said class
        Console.WriteLine("Enter in a description of the class.");
        string describe = Console.ReadLine();

        // Give days of the week
        Console.WriteLine("What days of the week do you attend? (M,T,W,*R,F)");
        Console.WriteLine("*R equals thursday");
        string weekdays = Console.ReadLine();

    }

    // Methods
    public abstract void Display();
    public abstract void Save();
}