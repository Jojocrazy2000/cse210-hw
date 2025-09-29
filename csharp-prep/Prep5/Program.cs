using System;
using System.Runtime.InteropServices;

class Program
{
    static void DisplayWelcome() // Prints out a message that says 'Welcome to the Program' 
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName() // Asks the User for their name, returns the data
    {
        Console.WriteLine("What is your name");
        return Console.ReadLine();
    }

    static int PromptUserNumber() // Asks the user for their favorite number, return the num
    {
        int input = 0;
        try
        {
            Console.WriteLine("What is your favorite number?");
            input = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error - {e}");
        }
        return input;
    }

    static void PromtUserBirthYear(ref int birth_year) // Asks the User for their birth year, does not return the data, but puts it into a passed by reference
    {
        try
        {
            Console.WriteLine("What is your birth year? IE 1990");
            birth_year = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error - {e}");
        }
    }

    static int SquareNumber(int num) // Accepts an integer and returns it squared
    {
        return num*num;
    }

    static void DisplayResult(string name, int sqr, ref int birth_year) // Displays the User's name, the squared number, and the birth year. Tells you how old you are.
    {
        System.DateTime moment = System.DateTime.Now;
        Console.WriteLine($"{name}, the square of your favorite number is {sqr}");
        Console.WriteLine($"{name}, your age is {moment.Year - birth_year}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        // Welcome message
        string name = PromptUserName();
        int sqr = SquareNumber(PromptUserNumber());
        int birth_year = 1901;
        // Variables

        // Main data
        PromtUserBirthYear(ref birth_year);

        DisplayResult(name, sqr, ref birth_year);
    }
}