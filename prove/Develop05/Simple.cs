public class Simple : Goal
{
    // Variables

    // Constructors
    public Simple(string task="Error", string description = "Null", int points = 0, bool complet = false) : base(task, description, points, complet)
    {

    }

    // Methods
    public override int CalculateScored()
    {
        if(!_completed)
        {
            _completed = true;
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
        if (_completed)
        {
            Console.WriteLine($"{_task}({_description}): [X]");
        }
        else
        {
            Console.WriteLine($"{_task}({_description}): [ ]");
        }
    }

    public override string Save()
    {
        return "s" + "," + _task + "," + _description + "," + _points + "," + _completed;
    }
}