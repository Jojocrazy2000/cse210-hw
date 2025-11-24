public class Simple : Goal
{
    // Variables

    // Constructors
    public Simple(string task="Error", string description = "Null", int points = 0) : base(task, description, points)
    {

    }

    // Methods
    public override int CalculateScored()
    {
        _completed = true;
        return _points;
    }

    public override void DisplayGoal()
    {
        if (_completed)
        {
            Console.WriteLine($"{_task}\n\t{_description}: [0]");
        }
        Console.WriteLine($"{_task}\n\t{_description}: [x]");
    }

    public override string Save()
    {
        return "s" + "," + _task + "," + _description + "," + _points + "," + _completed;
    }
}