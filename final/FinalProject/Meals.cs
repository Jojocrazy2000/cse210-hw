public class Meals : Plans
{
    // Variables
    private int _time;
    private string meal;

    // Constructor
    public Meals(string description, string day) : base(description, day)
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