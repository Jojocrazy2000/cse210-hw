public abstract class ToDo : Plan
{
    // Variables
    protected bool _completed;
    protected string _title;

    // Constructors
    public ToDo(string description, string day, bool completion = false) : base(description, day)
    {
        _completed = completion;

        // What would you title the task as?
        Console.WriteLine("What would you title the task as?");
        _title = Console.ReadLine();
    }

    // Methods
}