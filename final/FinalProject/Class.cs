public class Class : Plan
{
    // Variables
    private string _time;
    private string _code;
    private string _building;
    private string _room;
    private string _name;

    // Constructor
    public Class(string description, string day) : base(description, day)
    {
        // What is name of the class?
        Console.WriteLine("What is name of the class?");
        _name = Console.ReadLine();
        // What is the class code?
        Console.WriteLine("What is the class code?");
        _code = Console.ReadLine();
        // When does the class meet?
        Console.WriteLine("When does the class meet? Example 10:00");
        _time = Console.ReadLine();
        // Where does the class meet?
        Console.WriteLine("What building does the class meet at?");
        _building = Console.ReadLine();
        // What is the room number?
        Console.WriteLine("What is the room number?");
        _room = Console.ReadLine();
    }

    // Methods
    public override void Display()
    {
        Console.WriteLine($"-{_name}:{_code}- {_description}");
        Console.WriteLine($"Meets {_day}, at {_time}. Building {_building}, room {_room}");
    }

    public override void Save()
    {
        throw new NotImplementedException();
    }
}