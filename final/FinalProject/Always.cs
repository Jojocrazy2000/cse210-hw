public class Always : ToDo
{
    // Variables

    // Constructors
    public Always(string description, string day = null, bool completion = true) : base(description, day, completion)
    {
        
    }

    // Methods
    public void complet_step()
    {
    }
    public override void Display()
    {
        Console.WriteLine($"{_title} : {_description}. X/X");
    }

    public override void Save()
    {
        throw new NotImplementedException();
    }
}