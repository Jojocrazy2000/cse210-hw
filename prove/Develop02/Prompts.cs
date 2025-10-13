// Prompt Class
// Data: List<String> _prompts
// Method: Prompt()

class Prompt
{
    private string prompt;
    private List<string> _prompts = new List<string> { };

    public Prompt()
    {
        _prompts.Add("What was special about today?");
        _prompts.Add("Where did you go?");
        _prompts.Add("What can you tell that God helped you with today?");
        _prompts.Add("Who did you meet today? Did you already know them?");
        _prompts.Add("If you did something better today, what would it be?");
    }

    public string genPrompt()
    {
        Random rand = new Random();
        prompt = _prompts[rand.Next(5)];
        return prompt;
    }
}