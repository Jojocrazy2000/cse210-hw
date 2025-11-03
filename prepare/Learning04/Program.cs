using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment task_1 = new Assignment("John Lenon", "Communism");
        Console.WriteLine(task_1.GetSummary());

        MathAssignment task_2 = new MathAssignment("Issac Newton", "Science", "Gravity 101: 1.1", "Problems 1-3");
        Console.WriteLine(task_2.GetSummary());
        Console.WriteLine(task_2.GetHomeworkList());

        WritingAssignment task_3 = new WritingAssignment("Black Beard", "History", "The Final fight");
        Console.WriteLine(task_3.GetSummary());
        Console.WriteLine(task_3.GetWritingInformation());
    }
}