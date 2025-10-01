public class Resume
{
    private string _name;
    private List<Job> _jobs = new List<Job> { };

    public void Display()
    {
        Console.WriteLine("Name:");
        Console.WriteLine(_name);
        Console.WriteLine("Jobs:");
        for (int i = 0; i < _jobs.Count; i++)
        {
            _jobs[i].Display();
        }
    }

    public void Add_Job(Job job)
    {
        _jobs.Add(job);
    }

    public Resume(string name)
    {
        _name = name;
    }
}