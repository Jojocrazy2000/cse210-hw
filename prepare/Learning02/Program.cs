using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engeener", "Orange", 2000, 2010);

        Resume code_resume = new Resume("John");
        code_resume.Add_Job(job1);

        // job1.Display();

        code_resume.Display();
    }
}