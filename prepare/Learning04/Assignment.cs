public class Assignment
{
    protected string _studentName;
    private string _topic;
    // Variables
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
    // Methods

    // Constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
}