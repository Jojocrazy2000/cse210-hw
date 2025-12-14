public abstract class Plans
{
    // Variables
    protected String _description;
    protected String _day;

    // Constructor
    public Plans(string description, string day)
    {
        _description = description;
        _day = day;
    }

    // Methods
    public abstract void Display();
    public abstract void Save();
}