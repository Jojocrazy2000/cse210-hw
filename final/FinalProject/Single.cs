public class Single : ToDo
{
    // Variables

    // Constructors
    public Single(string description, string day = null) : base(description, day)
    {
        
    }

    // Methods
    public void complet_step()
    {
        _completed = true;
    }
    public override void Display()
    {
        if (_completed)
        {
            Console.WriteLine($"{_title} : {_description}. Completed");
        }
        Console.WriteLine($"{_title} : {_description}. 0/1");
    }

    public override void Save()
    {
        throw new NotImplementedException();
    }
}