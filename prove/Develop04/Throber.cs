class Throbber
{
    // Variables
    private List<string> _throb = ["/", "+", "-", "|"];
    private int _pacing;
    // Constructors
    public Throbber(int pace)
    {
        _pacing = pace;
        // _throb.Add("/");
        // _throb.Add("+");
        // _throb.Add("-");
        // _throb.Add("|");
    }

    // Methods
    public void setPace(int pace)
    {
        _pacing = pace * 1000;
    }

    public void Throb(string message = "", int length = 5)
    {
        TimeSpan ts = TimeSpan.FromSeconds(length);
        DateTime start = DateTime.Now;

        while (DateTime.Now - start < ts)
        {
            foreach(string icon in _throb)
            {
                Console.Clear();
                Console.Write($"{message} - ");
                Console.Write(icon);
                Thread.Sleep(100);
            }
        }
    }
}