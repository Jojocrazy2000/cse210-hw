class Word
{
    // variables
    private string _word;
    private bool _hidden;

    // methods
    public bool getHidden()
    {
        return _hidden;
    }

    public void setHidden(bool hide)
    {
        _hidden = hide;
    }

    public string getWord()
    {
        return _word;
    }
    // constructors
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
}