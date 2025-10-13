// Entry Class
// Data: string response, prompt, date
// Method: Display(), Prompt()
class Entry
{
    private string _response, _prompt, _date;

    public Entry(string prompt, string response, string date) // Consturctor only for saving
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public Entry() // General Construtor
    {
        Prompt bob = new Prompt();

        _prompt = bob.genPrompt();
        Console.WriteLine($"{_prompt}");
        _response = Console.ReadLine();

        _date = System.DateTime.Now.ToString();

    }

    public void Display()
    {
        Console.WriteLine($"***\nPrompt:{_prompt}");
        Console.WriteLine($"Response:{_response}");
        Console.WriteLine($"Date:{_date}");
    }

    public string getPrompt()
    {
        return _prompt;
    }

    public string getResponse()
    {
        return _response;
    }
    
    public string getDate()
    {
        return _date;
    }

    public void Prompt()
    {
        
    }
}