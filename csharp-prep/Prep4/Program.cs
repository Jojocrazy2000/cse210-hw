using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Variable hub
        List<int> user_input = new List<int>();
        int input = 1;
        int sum = 0, avg = 0, max, pos = 0;


        // Get a user generated list. End once a 0 is entered
        Console.WriteLine("----Welcome to John's list summarizer----");
        try
        {
            Console.Write("Enter in a number ->");
            input = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error - {e}");
        }
        while (input != 0)
        {
            user_input.Add(input);
            try
            {
                Console.Write("Enter in a number ->");
                input = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error - {e}");
            }
        }

        // Generate the sum
        foreach (int i in user_input)
        {
            sum += i;
        }

        // Generate the avg.
        foreach (int i in user_input)
        {
            avg += i;
        }
        avg = avg / user_input.Count;

        // Generate the Max number
        max = user_input[0];
        foreach (int i in user_input)
        {
            if (i > max)
            {
                max = i;
            }
        }

        // Generate the largest positive number
        foreach (int i in user_input)
        {
            if (i > pos)
            {
                pos = i;
            }
        }


        foreach (int i in user_input)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine($"Sum: {sum}"); //Sum
        Console.WriteLine($"Average: {avg}"); //Avg
        Console.WriteLine($"Maximun: {max}"); //Max
        Console.WriteLine($"Largest Positive number: {pos}"); // 
        // Sort? Print the List
        

    }
}