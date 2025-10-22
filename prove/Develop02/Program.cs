using System;


class Program
{
    static void Main(string[] args)
    {
        int choice = 99;
        Journal notebook = new Journal();
        // Variables
        
        while (choice != 0)
        {
            Console.WriteLine("----/ Welcome to your Journal /----");
            Console.WriteLine("0)Exit\n1)Save Journal\n2)Load Journal\n3)New Entry\n4)Show Journal");

            // Loop thing
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }

            switch(choice)
            {
                case 1:
                    notebook.Save();
                    break;
                case 2:
                    notebook.Load();
                    break;
                case 3:
                    notebook.newEntry();
                    break;
                case 4:
                    notebook.Display();
                    Console.WriteLine("Enter any Key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}