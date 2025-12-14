public class Events : Plans
{
    // Variables
    private int _time;
    private string _date;
    private string time_of_day;

    // Constructor
    public Events(string description, string day, int time, string date, string time_of_day = null) : base(description, day)
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