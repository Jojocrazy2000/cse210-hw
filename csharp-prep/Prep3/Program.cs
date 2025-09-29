using System;

class Program
{
    static void Main(string[] args)
    {
        // Random Class
        var rand = new Random();

        // Variable hub
        int play = 1;
        int magic_number = rand.Next(99 + 1);
        int guess = 0;


        Console.WriteLine("----Welcome to Your wonderful magician Dylan----");
        // Program loop
        while (play != 0)
        {
            // Get the players guess
            Console.Write("What do you guess the number is? -> ");
            try
            {
                guess = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error - {e}");
            }

            // Check the guess against the magic number
            if (guess == magic_number)
            {
                play = 0;
            }
            else if (guess > magic_number)// Give a lower or higher
            {
                play = 1;
                Console.WriteLine("Lower");
            }
            else if (guess < magic_number)
            {
                play = 1;
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You Got me! You guessed the right number.");
    }
}