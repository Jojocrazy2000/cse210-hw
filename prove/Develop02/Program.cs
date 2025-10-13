using System;


class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal notebook = new Journal();
        // Variables

        Console.WriteLine("----/ Welcome to your Journal /----");
        Console.WriteLine("0)Exit\n1)Save Journal\n2)Load Journal\n3)New Entry");

        // Loop thing
        try
        {
            choice = int.Parse(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine($"Error: {e}");
        }
        
        while (choice != 0)
        {
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
            }
        }
    }
}