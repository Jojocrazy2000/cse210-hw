// Journal Class
// Data: entries List<Entry>, string filepath
// Method: Save(), Load(), Display()


class Journal
{
    private List<Entry> _entries = new List<Entry> { };
    private string _filepath = "";

    public void Save()
    {
        if (_filepath == "") // Verifies if there is an already existing file
        {
            Console.WriteLine("Enter in the filename you would like to save to? ");
            _filepath = "C:\\Users\\jacob\\BYUI Collage classes\\2025 Fall\\cse210-hw\\prove\\Develop02\\" + Console.ReadLine() + ".txt";
        }

        try
        {
            StreamWriter sw = new StreamWriter(_filepath, false); // Write to file
            foreach(Entry copy in _entries)
            {
                sw.WriteLine($"{copy.getPrompt()}\n{copy.getResponse()}\n{copy.getDate()}");
            }
            sw.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine($"Error:{e}");
        }

    }

    public void Load()
    {
        Console.WriteLine("Enter in the filename you would like to load? ");
        _filepath = "C:\\Users\\jacob\\BYUI Collage classes\\2025 Fall\\cse210-hw\\prove\\Develop02\\" + Console.ReadLine() + ".txt";

        try
        {
            StreamReader sw = new StreamReader(_filepath); // Read to object list

            string prompt = sw.ReadLine();
            string response = sw.ReadLine();
            string date = sw.ReadLine();

            _entries.Clear();
            while (prompt != null || response != null || date != null)
            {
                _entries.Add(new Entry(prompt, response, date));
                // Read the next three lines of said file
                prompt = sw.ReadLine();
                response = sw.ReadLine();
                date = sw.ReadLine();
            }

            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error:{e}");
        }
    }

    public void newEntry()
    {
        _entries.Add(new Entry());
    }

    public void Display()
    {
        foreach (Entry copy in _entries)
        {
            copy.Display();
        }
    }
}