public class Events : Plan
{
    // Variables
    private string _time;
    private string _date;
    private string _time_of_day; //AM or PM. Mabey 24hr?
    private string _name;

    // Constructor
    public Events(string description, string day) : base(description, day)
    {
        // Get the name of the event
        Console.WriteLine("What is the name of the event?");
        _name = Console.ReadLine();

        // Get the time of the event along with AM or PM
        Console.WriteLine("What time of day is the event?");
        _time = Console.ReadLine();

        Console.WriteLine("AM or PM?");
        _time_of_day = Console.ReadLine(); 
        // get the date of the event
        Console.WriteLine("When is the event? Enter in the date."); 
        _date = Console.ReadLine();       
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