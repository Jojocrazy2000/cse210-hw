public class Eternal : Goal
{
    // Variables

    // Constructors
    public Eternal(string task="Error", string description = "Null", int points = 0) : base(task, description, points)
    {
        
    }

    // Methods
    public override int CalculateScored()
    {
        return _points;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{_task}\n\t{_description}: [00]");
    }

    public override string Save()
    {
        return "e" + "," + _task + "," + _description + "," + _points + "," + _completed;
    }
}