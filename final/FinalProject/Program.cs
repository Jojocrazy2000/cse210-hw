using System;
using System.ComponentModel;
using System.Security.AccessControl;

//     For future reference if I ever come back to this I could add a seperate person class so that one could place identifying 
//  information with their plans. Another feature could be that profiles saved as read only cannot be edited by the program, only
//  viewed.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        // local variables
        string choice = "";
        List<Plan> plans = new List<Plan>(); // This is just here so that any new classes added don't have to have another structure
        List<Events> events = new List<Events>();
        List<Classes> classes = new List<Classes>();
        List<ToDo> toDos = new List<ToDo>();
        List<Meal> meals = new List<Meal>();

        // initalzing the main loop
        while (choice != "0")
        {
            // Intro sequence
            Console.WriteLine("---- Student Life Plans ----");
            Console.WriteLine("0)Exit\n1)See Plans\n2)See individual plans\n3)Add a plan\n4)Save/Load plans");
            choice = Console.ReadLine();

            if(choice == "1")
            {
                // Display all plans
                foreach(Plan item in classes)
                {
                    item.Display();
                }
                foreach(Plan item in toDos)
                {
                    item.Display();
                }
                foreach(Plan item in events)
                {
                    item.Display();
                }
                foreach(Plan item in meals)
                {
                    item.Display();
                }
            }
            else if(choice == "2")
            {
                // Let the user see each catagory of plan and be able to choose one
                   
            }
            else if(choice == "3")
            {
                // Let the user choose from the list of plans and add to said list
                Console.Clear();
                Console.WriteLine("---- Student Life Plans ----");
                Console.WriteLine("*Adding event*");
                Console.WriteLine("1)Class List\n2)To-Do list\n3)Coming Events\n4)Meal Prep");
                int select;
                try
                {
                    select = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalide input");
                    continue;
                }

                if(select == 1) // Class list
                {
                    // Give description of said class
                    Console.WriteLine("Enter in a description of the class.");
                    string describe = Console.ReadLine();

                    // Give days of the week
                    Console.WriteLine("What days of the week do you attend? (M,T,W,*R,F)");
                    Console.WriteLine("*R equals thursday");
                    string weekdays = Console.ReadLine();

                    // Create object
                    classes.Add(new Classes(describe, weekdays));
                }
                else if(select == 2) // Todo list
                {
                    // Give description of todo item
                    Console.WriteLine("Enter in a description of the todo item.");
                    string describe = Console.ReadLine();

                    // Give days of the week
                    Console.WriteLine("What day of the week do you need this done by? (S, M, T, W, *R, F, S or None)");
                    Console.WriteLine("*R equals thursday");
                    string weekday = Console.ReadLine();

                    // Is this a simple, eternal, or Muiltiple object?
                    Console.WriteLine("Is this a simple todo, a todo that always needs to happen, or just a few times todo?");
                    Console.WriteLine("1)Simple\n2)Always\n3)Few times");
                    int which_object;
                    try
                    {
                        which_object = int.Parse(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Unknown entry. Exiting program");
                        which_object = 0;
                        continue;
                    }

                    // Create object
                    if(which_object == 1)
                    {
                        toDos.Add(new Single(describe, weekday));
                    }
                    else if(which_object == 2)
                    {
                        toDos.Add(new Always(describe, weekday));
                    }
                    else if(which_object == 3)
                    {
                        toDos.Add(new Always(describe, weekday));
                    }
                }
                else if(select == 3) // Events
                {
                    // Give description of the event
                    Console.WriteLine("Enter in a description of the Event.");
                    string describe = Console.ReadLine();

                    // Give days of the week
                    Console.WriteLine("What day of the week is it? (M,T,W,*R,F)");
                    Console.WriteLine("*R equals thursday");
                    string weekdays = Console.ReadLine();

                    // Create object
                    events.Add(new Events(describe, weekdays));
                }
                else if(select == 4) // Meal prep
                {
                    // Give description of the event
                    Console.WriteLine("Enter in a description of the Meal.");
                    string describe = Console.ReadLine();

                    // Give days of the week
                    Console.WriteLine("What day of the week is it? (SU,M,T,W,*R,F,SA)");
                    Console.WriteLine("*R equals thursday");
                    string weekdays = Console.ReadLine();

                    // Create object
                    meals.Add(new Meal(describe, weekdays));
                }
                // **Secondary objective, allow the user to delete plans
            }
            else if(choice == "4")
            {
                // Tentative capability. Will allow the user to save and load their plans as a profile.
            }
            else if(choice == "0")
            {
                Console.WriteLine("Have a wonderful day Student");
                break;
            }
            // Main select sequence
            // Option 1. See plans
            // Option 2. See individual plans
            // Options 2a-2? have each class be capable of being shown by themselves
            // Option 3. Add a plan
            // Option 4. Save/Load plans

        }

        
    }
}