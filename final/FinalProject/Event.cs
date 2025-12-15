public class Event : Plan
{
    // Variables
    private string _time;
    private string _date;
    private string _time_of_day; //AM or PM. Mabey 24hr?
    private string _name;

    // Constructor
    public Event(string description, string day) : base(description, day)
    {
        // Get the name of the event
        Console.WriteLine("What is the name of the event?");
        _name = Console.ReadLine();

        // Get the time of the event along with AM or PM
        Console.WriteLine("What time is the event?");
        _time = Console.ReadLine();

        Console.WriteLine("AM or PM?");
        _time_of_day = Console.ReadLine(); 
        // get the date of the event
        Console.WriteLine("When is the event? Enter in the date like mm-dd-yy."); 
        _date = Console.ReadLine();       
    }

    // Methods
    public override void Display()
    {
        Console.WriteLine($"{_name} : {_description}. {_day} {_date} at {_time}{_time_of_day}");
    }

    public override void Save()
    {
        throw new NotImplementedException();
    }
}