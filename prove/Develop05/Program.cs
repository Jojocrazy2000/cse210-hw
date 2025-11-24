using System;

class Program
{
    static void Main(string[] args)
    {
        int select = 99;
        int points = 0;
        List<Goal> goals = new List<Goal>();
        string filename;

        while(select > 0 || select < 0)
        {
            Console.Clear();
            Console.WriteLine("-----Welcome to Bob's Goal Emporium-----");
            Console.WriteLine($"Points: {points}");
            Console.WriteLine("0)Exit\n1)Add Goal\n2)Log Event\n3)Display Goals\n4)Save\n5)Load");
            try
            {
                select = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("Invalid input");
            }
            
            switch(select)
            {
                case 0:
                    Console.WriteLine("Have a Good day");
                    break;
                case 1: // Add Goal to goals
                    string task;
                    string description;
                    int reward = 0;
                    // Variables for Goal

                    Console.WriteLine("Which Goal do you want to add?"); // Select a Goal to add
                    Console.WriteLine("1)Simple\n2)Eternal\n3)Checklist");
                    string which = Console.ReadLine();

                    // Information all Goals need
                    Console.WriteLine("What is the Goal?"); 
                    task = Console.ReadLine();
                    Console.WriteLine("What are you doing to achieve said Goal?");
                    description = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("How much should the goal award");
                        reward = int.Parse(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                        break;
                    }

                    if (which == "3")
                    {
                        int bonus, loops;
                        try
                        {
                            Console.WriteLine("How many times do you want to check this off?");
                            loops = int.Parse(Console.ReadLine());
                            Console.WriteLine("How much should competing this task reward?");
                            bonus = int.Parse(Console.ReadLine());
                        }
                        catch(Exception e)
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                            break;
                        }
                        
                        goals.Add(new Checklist(task, description, reward, bonus, loops));
                    }
                    else if (which == "2")
                    {
                        goals.Add(new Eternal(task, description, reward));
                    }
                    else
                    {
                        goals.Add(new Simple(task, description, reward));
                    }
                    Console.Clear();
                    break;
                case 2: // Complete a Goal
                    int i = 1;
                    int choose;

                    Console.WriteLine("Which Goal would you wish to complet/checkoff?");
                    foreach (Goal check in goals)
                    {
                        Console.Write($"{i}]");
                        check.DisplayGoal();
                        i += 1;
                    }

                    try
                    {
                        choose = int.Parse(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                        break;
                    }

                    int basic = goals[choose - 1].CalculateScored();
                    points += basic;
                    Console.WriteLine($"{basic} points were awarded");
                    Console.WriteLine("Enter any Key to continue...");
                    Console.ReadKey();
                    break;
                case 3: // See all goals and their condition
                    Console.Clear();
                    foreach (Goal check in goals)
                    {
                        check.DisplayGoal();
                    }
                    Console.WriteLine("Enter any Key to continue...");
                    Console.ReadKey();
                    break;
                case 4: // Save
                    Console.WriteLine("What is the filename of the file you wish to save to?");
                    filename = Console.ReadLine();
                    save(ref goals, filename, ref points);
                    break;
                case 5: // Load
                    Console.WriteLine("What is the filename of the file you wish to load?");
                    filename = Console.ReadLine();
                    load(ref goals, filename, ref points);
                    break;
                case 99: // Developer mode
                    // Just here so that invalid inputs don't do the funny
                    break;
                default: // Huh?
                    Console.WriteLine("Admin rights accessed");
                    break;
            }
        }
        

    }
    static void save(ref List<Goal> goals, string filename, ref int points)
    {
        List<string> buffer = new List<string>();
        // Variables

        if (!filename.Contains(".txt"))
        {
            filename = filename + ".txt";
        }

        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamWriter sw = new StreamWriter(filename);
            
            // Write the score to the save point
            sw.WriteLine(points);

            foreach (Goal item in goals) // Get every scripture
            {
                sw.WriteLine(item.Save()); // Write the reference
            }

            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
    static void load(ref List<Goal> goals, string filename, ref int points)
    {
        String line;
        // Variables
        
        if (!filename.Contains(".txt"))
        {
            filename = filename + ".txt";
        }

        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(filename);
            //Read the first line of text
            points = int.Parse(sr.ReadLine());
            //Continue to read until you reach end of file
            line = "";

            line = sr.ReadLine();

            while (line != null)
            {
                //Read the next line
                string [] buffer = line.Split(",");
                if (buffer[0] == "s")
                {
                    bool completed;
                    if(buffer[4] == "True")
                    {
                        completed = true;   
                    }
                    else
                    {
                        completed = false;
                    }
                    goals.Add(new Simple(buffer[1], buffer[2], int.Parse(buffer[3]), completed));
                }
                if (buffer[0] == "e")
                {
                    goals.Add(new Eternal(buffer[1], buffer[2], int.Parse(buffer[3])));
                }
                if (buffer[0] == "cl")
                {
                    bool completed;
                    if(buffer[6] == "True")
                    {
                        completed = true;   
                    }
                    else
                    {
                        completed = false;
                    }
                    int amount = int.Parse(buffer[5]);
                    goals.Add(new Checklist(buffer[1], buffer[2], int.Parse(buffer[3]), int.Parse(buffer[4]), int.Parse(buffer[7]), completed, amount));
                }
                line = sr.ReadLine();
            }

            foreach (Goal check in goals)
            {
                check.DisplayGoal();
            }
            Console.WriteLine("Enter any Key to continue");
            Console.ReadLine();
            //close the file
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
}