class Activity
{
    // Variables
    protected Throbber _throb;
    protected string _startingMessage;
    protected string _endingMessage;
    protected int _duration;
    private string _description;


    // Constructors
    public Activity(string description)
    {
        Console.WriteLine("How many seconds do you want the activity to run for?");
        try
        {
            _duration = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error - {e}");
            Console.WriteLine("Default time of 10 seconds set");
            _duration = 10;
        }

        _throb = new Throbber(_duration);
        _startingMessage = "Lets get started with helping you learn to slow down.";
        _endingMessage = "Thank you for slowing down. Come back if you need anymore help.";
        _description = description;
        }

    // Methods
    public void DisplayInstructions()
    {
        Console.WriteLine($"{_startingMessage}\n{_description}");
    }
    
    public void SetTimer(int new_duration)
    {
        // ?
    }
}