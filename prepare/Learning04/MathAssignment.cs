public class MathAssignment : Assignment
{
    // Variables
    private string _textbookSection;
    private string _problems;

    // Constructors
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    // Methods
    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }
}