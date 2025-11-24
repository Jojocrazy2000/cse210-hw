public class Checklist : Goal
{
    // Variables
    private int _iterations;
    private int _completionBonus;
    private int _loops;

    // Constructors
    public Checklist(string task="Error", string description = "Null", int points = 0, int BonusPoints = 0, int amount = 1) : base(task, description, points)
    {
        _iterations = 0;
        _loops = amount;
        _completionBonus = BonusPoints;
    }

    // Methods
    public override int CalculateScored()
    {
        if (_iterations >= _loops)
        {
            _completed = true;
            return _completionBonus;
        }
        _iterations += 1;
        return _points;
    }

    public override void DisplayGoal()
    {
        if (_completed)
        {
            Console.WriteLine($"{_task}\n\t{_description}: [{_iterations}]/[{_loops}]");
        }
        Console.WriteLine($"{_task}\n\t{_description}: [X]/[X]");
    }

    public override string Save()
    {
        return _task + "," + "," + _description + "," + _points + "," + _completionBonus + "," + _completed + "," + _iterations + "," + _loops;
    }
}