using System.Net.Mime;
using System.Runtime.InteropServices;

class Scripture
{
    // variables
    private List<Verse> _verses = new List<Verse>();
    private Reference _reference;

    // methods
    public void Display()
    {
        int i = 1;
        Console.Clear();
        Console.WriteLine($"{_reference.getReference()}");
        foreach(Verse verse in _verses)
        {
            Console.Write($"{i} ");
            verse.Display();
            i++;
        }
    }

    public void Scram()
    {
        Random rand = new Random();

        for (int i = 0;i <= _verses.Count ; i++)
        {
            int select = rand.Next(_verses.Count);
            if (!_verses[select].AllHidden())
            {
                _verses[select].Scram();
                break;
            }
        } 
        

        // foreach (Verse item in _verses)
        // {
        //     item.Scram();
        // }
    }

    // public void SetVerses(List<string> Scripture, string reference)
    // {
    //     foreach (string verse in Scripture)
    //     {

    //     }
    // }

    // public void SetRef(Ref reference)
    // {
    //     _reference = reference;
    // }

    public string getReference()
    {
        return _reference.getReference();
    }
    
    public bool AllHidden()
    {
        int count = 0;
        foreach (Verse test in _verses)
        {
            if (test.AllHidden())
            {
                count++;
            }
        }

        if (count == _verses.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Memorize()
    {
        string condition = "";
        while (condition.ToLower() != "quit")
        {
            Display();
            Console.WriteLine("Press Enter to hide a few words or 'quit' to exit");
            condition = Console.ReadLine();
            if (AllHidden())
            {
                break;
            }
            Scram();
        }
        foreach (Verse reset in _verses)
        {
            reset.Reset();
        }
    }
    
    public List<Verse> getVerses()
    {
        return _verses;
    }

    // constructors
    public Scripture(string book, string reference, string verse)
    {
        _reference = new Reference(book, reference);
        _verses.Add(new Verse(verse));
    }
    public Scripture(string book, string reference, List<string> verses)
    {
        _reference = new Reference(book, reference);
        foreach (string verse in verses)
        {
            _verses.Add(new Verse(verse));
        }
    }
}