public class Always : ToDo
{
    // Variables

    // Constructors
    public Always(string description, string day = null) : base(description, day)
    {
        
    }

    // Methods
    public override void Display()
    {
        throw new NotImplementedException();
    }

    public override void Save()
    {
        throw new NotImplementedException();
    }
}