public class Checklist : Goal
{
    // Variables
    private int _iterations;
    private int _completionBonus;
    private int _loops;

    // Constructors
    public Checklist(string task="Error", string description = "Null", int points = 0, int BonusPoints = 0, int amount = 1, bool complet = false, int iterations = 1) : base(task, description, points, complet)
    {
        _iterations = iterations;
        _loops = amount;
        _completionBonus = BonusPoints;
    }

    // Methods
    public override int CalculateScored()
    {
        if(!_completed)
        {
            if (_iterations >= _loops)
            {
                _completed = true;
                return _completionBonus;
            }
            _iterations += 1;
            return _points;
        }
        else
        {
            Console.WriteLine("Goal already completed");
            return 0;
        }
        
    }

    public override void DisplayGoal()
    {
        if (!_completed)
        {
            Console.WriteLine($"{_task}({_description}): [{_iterations - 1}/{_loops}]");
        }
        else
        {
            Console.WriteLine($"{_task}({_description}): [X/X]");
        }
    }

    public override string Save()
    {
        return "cl" + "," + _task  + "," + _description + "," + _points + "," + _completionBonus  + "," + _iterations + "," +_completed  + "," + _loops;
    }
}