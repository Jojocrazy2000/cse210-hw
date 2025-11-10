class Listing : Activity
{
    // Variables
    private List<string> _prompts = new List<string>();
    private List<int> _usedPrompts;

    private int _entryCount;

    // Constructors
    public Listing() : base("This activity is a way to list all the positive things relating to the prompt")
    {
        _prompts.Add("Who have inspired you?");
        _prompts.Add("What are your personal strengths?");
        _prompts.Add("Who did you help this week?");
        _prompts.Add("Who do you look up too?");
        _prompts.Add("Who have inspired you?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
    }
    // Methods
    public void DisplayPrompt()
    {
        TimeSpan ts = TimeSpan.FromSeconds(_duration);
        DateTime start = DateTime.Now;

        string rand_prompt = SetRandomPrompt();

        countdown(rand_prompt);

        while (DateTime.Now - start < ts)
        {
            Console.WriteLine($"{rand_prompt}\nEnter your thought: ");
            Console.ReadLine();
            _entryCount++;
        }

        Console.WriteLine($"You entered in {_entryCount} thoughts.");
        Console.WriteLine($"{_endingMessage}");
    }

    public string SetRandomPrompt()
    {
        Random rand = new Random();

        int selector = rand.Next(_prompts.Count());

        return _prompts[selector];
    }
    
    public void countdown(string message, int length = 5)
    {
        for (int i = length; i > 0; i--)
        {
            Console.Clear();
            Console.Write($"{message} - {i}");
            Thread.Sleep(1000);
        }
    }
}