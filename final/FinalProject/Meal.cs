public class Meal : Plan
{
    // Variables
    private int _time; // Is this needed?
    private string _meal;

    // Constructor
    public Meal(string description, string day) : base(description, day)
    {
        Console.WriteLine("What meal of the day is it?");
        Console.WriteLine("1)Breakfast\n2)Lunch\n3)Dinner");
        _meal = Console.ReadLine();
    }

    // Methods
    public override void Display()
    {
        if(_meal == "1")
        {
            Console.WriteLine($"{_day},Breakfast : {_description}");
        }
        else if(_meal == "2")
        {
            Console.WriteLine($"{_day},Lunch : {_description}");
        }
        else if(_meal == "3")
        {
            Console.WriteLine($"{_day},Dinner : {_description}");
        }
        
    }

    public override void Save()
    {
        throw new NotImplementedException();
    }
}