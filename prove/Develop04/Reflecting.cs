using System.Diagnostics.Contracts;

class Reflecting : Activity
{
    // Variables
    private List<string> _prompts = new List<string>();
    private List<int> _usedPromts;

    // Constructors
    public Reflecting() : base("This activity gives you time to think about recent moments where you have showed strength, resilance, and capability.")
    {
        _prompts.Add("Think of a time when you did something hard. How did you feel afterwards?");
        _prompts.Add("Think of when you did a good job.");
        _prompts.Add("Think of who you were kind to recently");
        _prompts.Add("Think about what made you laugh recently");
        _prompts.Add("Think about what you selflessly did for others");
        _prompts.Add("What is your favorite memory of this week");
    }

    // Methods
    public void DisplayPrompt()
    {
        TimeSpan ts = TimeSpan.FromSeconds(_duration);
        DateTime start = DateTime.Now;

        while (DateTime.Now - start < ts)
        {
            string rand_prompt = SetRandomPrompt();
            _throb.Throb(rand_prompt);
        }

        Console.WriteLine($"{_endingMessage}");
    }

    public string SetRandomPrompt()
    {
        Random rand = new Random();

        int selector = rand.Next(_prompts.Count());

        return _prompts[selector];
    }
}