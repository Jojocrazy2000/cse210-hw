using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Job
{
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endyear;

    public void Display() // Display's the entire Job
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endyear}");
    }

    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endyear = endYear;
    }
}