using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int select = 99;
        while(select > 0)
        {
            // -----Select menu-----
            Console.WriteLine("-----Mindfulness Program-----");
            Console.WriteLine("0) Exit\n1) Square Breathing\n2) Reflecting\n3) Listing");
            try
            {
                select = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error - {e}");
            }
            // -----Select menu----- 

            // -----Switch Case-----
            switch (select)
            {
                case 1:
                    Breathing square = new Breathing();
                    square.DisplayInstructions();
                    square.BreathingLoop();
                    break;
                case 2:
                    Reflecting think = new Reflecting();
                    think.DisplayInstructions();
                    think.DisplayPrompt();
                    break;
                case 3:
                    Listing list = new Listing();
                    list.DisplayInstructions();
                    list.DisplayPrompt();
                    break;
            }
            
            // -----Switch Case-----
        }
    }
}