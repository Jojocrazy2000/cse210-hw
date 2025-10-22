class Verse
{
    // variables
    private List<Word> _words = new List<Word>();

    // methods
    public void Display()
    {
        foreach (Word show in _words)
        {
            if (!show.getHidden())
            {
                Console.Write($" {show.getWord()} ");
            }
            else
            {
                Console.Write(" ");
                foreach (char letter in show.getWord())
                {
                    Console.Write("-");
                }
                Console.Write(" ");
            }
        }
        Console.Write("\n");
    }

    // public string GetWord() //What does this one do?
    // {

    // }

    public void Scram()
    {
        Random rand = new Random();
        
        for(int i = 0; i < rand.Next(3,6); i++)
        {
            while(true)
            {
                int select = rand.Next(_words.Count);
                if(!_words[select].getHidden())
                {
                    _words[select].setHidden(true);
                    break;
                }
                Console.Write("*-*");
                if(AllHidden())
                {
                    break;
                }
            }
            
        }

        // foreach (Word item in _words)
        // {
        //     item.setHidden(true);
        // }
    }
    
    public void Reset()
    {
        foreach(Word rewind in _words)
        {
            rewind.setHidden(false);
        }
    }

    public bool AllHidden()
    {
        foreach (Word test in _words)
        {
            if (!test.getHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void setWord(Word input)
    {
        _words.Append(input);
    }

    // constructors
    public Verse(string verse)
    {
        string[] split = verse.Split(" ");
        foreach(string word in split)
        {
            _words.Add(new Word(word));
        }
    }
}