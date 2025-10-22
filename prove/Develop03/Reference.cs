class Reference
{
    // Variables
    private string _book;
    private string _verses;

    // Methods
    public void Display()
    {

    }

    public string getReference()
    {
        return _book + ":" + _verses;
    }

    // Constructors
    public Reference(string book, string verses)
    {
        _book = book;
        _verses = verses;
    }
}