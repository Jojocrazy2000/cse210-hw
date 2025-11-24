public abstract class Goal
{
    // Variables
    protected string _task;
    protected string _description;
    protected int _points; // Points per completion of a Goal
    protected bool _completed; // Bool value which checks if the goal is done.

    // Constructors
    public Goal(string task="Error", string description = "Null", int points = 0, bool complet = false)
    {
        _task = task;
        _description = description;
        _points = points;
        _completed = complet;
    }

    // Methods
    public abstract int CalculateScored(); // returns the score of that goal
    public abstract void DisplayGoal(); // Displays the goal and its sitrep
    public abstract string Save();
}