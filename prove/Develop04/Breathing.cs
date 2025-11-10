using System.ComponentModel.DataAnnotations;

class Breathing : Activity
{
    // Variables
    private int _pace;

    // Constructors
    public Breathing() : base("This is Square breathing. You breath in, hold, breath out, hold. For how long is your choice.")
    {
    }

    // Methods
    public void BreathingLoop()
    {
        string[] square = ["...Breath in...", "...Hold...", "...Breathout...", "...Hold..."];
        TimeSpan ts = TimeSpan.FromSeconds(_duration);
        DateTime start = DateTime.Now;

        int i = 0;
        while (DateTime.Now - start < ts)
        {
            // foreach (string icon in square)
            // {
            //     _throb.Throb(icon);
            // }
            _throb.Throb(square[i]);
            i++;
            if (i >= square.Count())
            {
                i = 0;
            }
        }
        Console.Clear();
        Console.WriteLine($"{_endingMessage}");
    }
}