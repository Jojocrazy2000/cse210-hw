public class Meal : Plan
{
    // Variables
    private int _time; // Is this needed?
    private string meal;

    // Constructor
    public Meal(string description, string day) : base(description, day)
    {
        Console.WriteLine("What meal of the day is it?");
        Console.WriteLine("1)Breakfast\n2)Lunch\n3)Dinner");
        meal = Console.ReadLine();
    }

    // Methods
    public override void Display()
    {
        throw new NotImplementedException();
    }

    public override void Save()
    {
        throw new NotImplementedException();
    }
}