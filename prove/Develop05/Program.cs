using System;

class Program
{
    static void Main(string[] args)
    {
        int select = 99;
        int points = 0;
        List<Goal> goals = new List<Goal>();

        while(select != 99)
        {
            Console.WriteLine("-----Welcome to Bob's Goal Emporium-----");
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
                            Console.WriteLine("How many time do you want to check this off?");
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

                    points += goals[choose].CalculateScored();
                    break;
                case 3: // See all goals and their condition
                    foreach (Goal check in goals)
                    {
                        check.DisplayGoal();
                    }
                    break;
                case 4: // Save
                    break;
                case 5: // Load
                    break;
                case 99: // Developer mode
                    // Just here so that invalid inputs don't do the funny
                    break;
                default: // Huh?
                    Console.WriteLine("Admin right accessed");
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

            while (line != null)
            {
                //Read the next line
                line = sr.ReadLine();

                if(line.Contains(","))
                {
                    string [] buffer = line.Split(",");
                }
            }
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