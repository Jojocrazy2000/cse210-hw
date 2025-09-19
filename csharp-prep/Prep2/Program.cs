using System;

class Program
{
    static void Main(string[] args)
    {
        int score;
        string letter_grade;
        // Take in an integer for a grade, then return what the letter grade would be
        Console.WriteLine("What is your total score?");
        score = int.Parse(Console.ReadLine());

        // Letter grade classification
        if (score >= 90)
        {
            letter_grade = "A";
        }
        else if (score >= 80)
        {
            letter_grade = "B";
        }
        else if (score >= 70)
        {
            letter_grade = "C";
        }
        else if (score >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }

        // Declaration of what our letter grade is
        Console.WriteLine($"Your letter grade then is {letter_grade}");
    }
}