using System;

class Program
{
    static bool IsMinus(int score) // Function for minus sign
    {
        if (score % 10 <= 3)
        { return true; }
        return false;
    }

    static bool IsPlus(int score)// Function for the plus sign
    {
        if (score % 10 <= 7)
        { return true; }
        return false;
    }


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
            if (IsMinus(score))
            {
                letter_grade += '-';
            }
        }
        else if (score >= 80)
        {
            letter_grade = "B";
            if (IsPlus(score))
            {
                letter_grade += '+';
            }
            else if (IsMinus(score))
            {
                letter_grade += '-';
            }
        }
        else if (score >= 70)
        {
            letter_grade = "C";
            if (IsPlus(score))
            {
                letter_grade += '+';
            }
            else if (IsMinus(score))
            {
                letter_grade += '-';
            }
        }
        else if (score >= 60)
        {
            letter_grade = "D";
            if (IsPlus(score))
            {
                letter_grade += '+';
            }
            else if (IsMinus(score))
            {
                letter_grade += '-';
            }
        }
        else
        {
            letter_grade = "F";
        }

        // Declaration of what our letter grade is
        Console.WriteLine($"Your letter grade then is {letter_grade}");
    }
}