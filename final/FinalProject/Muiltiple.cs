public class Muiltiple : ToDo
{
    // Variables
    private int _iterations;
    private int _count;

    // Constructors
    public Muiltiple(string description, string day = null) : base(description, day)
    {
        // How many iterations do you want?
        Console.WriteLine("How many times does this task need completing");
        try
        {
            _iterations = int.Parse(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine("Error unknown input. Defaulted to 1");
        }
        _count = 0;
    }

    // Methods\
    public void complet_step()
    {
        _count++;
        if(_count >= _iterations)
        {
            _completed = true;
            _count = _iterations;
        }
        
    }
    public override void Display()
    {
        if (_completed)
        {
            Console.WriteLine($"{_title} : {_description}. Completed");
        }
        Console.WriteLine($"{_title} : {_description}. {_completed}/{_iterations}");
    }

    public override void Save()
    {
        throw new NotImplementedException();
    }
}