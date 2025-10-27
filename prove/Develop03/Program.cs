using System;

class Program
{
    
    
    static void ShowScriptureList(ref List<Scripture> scriptures)
    {
        int i = 1;
        foreach (Scripture script in scriptures)
        {
            Console.WriteLine($"{i}) {script.getReference()}");
            i++;
        }
    }
    static void Main(string[] args)
    {
        // Variables
        List<Scripture> _scriptures = new List<Scripture>();
        string direction = "1";

        while (direction != "0")
        {
            Console.WriteLine("----/ Scripture Memorizore 2000 /----");
            Console.WriteLine("0) Exit\n1) Show Scriptures\n2) Memorize Scripture\n3) Add Scripture\n4) Save Scripture\n5) Load Scripture");
            direction = Console.ReadLine();

            if (direction == "1")
            {
                ShowScriptureList(ref _scriptures);
                Console.WriteLine("Enter any key to continue");
                Console.ReadKey();
            }
            else if (direction == "2")
            {
                Console.WriteLine("Which one do you want to choose?");
                ShowScriptureList(ref _scriptures);
                try
                {
                    int option = int.Parse(Console.ReadLine()) - 1;
                    _scriptures[option].Memorize();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error - {e}");
                }

            }
            else if (direction == "3") // This...this is a lot...
            {
                List<string> verses = new List<string>();
                string verse = "";
                // base variables

                Console.WriteLine("What is the book & chapter? I.E. 1 Nephi 8");
                string book = Console.ReadLine();

                Console.WriteLine("What is the first verse you want to memorize?");
                string first = Console.ReadLine();
                Console.WriteLine("What is the last verse you want to memorize?");
                string second = Console.ReadLine();

                // /----
                int verse_count = -1;
                try
                {
                    verse_count = int.Parse(second) - int.Parse(first); // Turns the input string into an int, if possible

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error - {e}");
                }
                // ----/

                if (verse_count > 0)
                {
                    int intital = int.Parse(first);
                    for (int i = 0; i <= verse_count; i++) // Make a verse in the range verse_count
                    {
                        Console.WriteLine($"Enter in Verse {intital}");
                        verses.Add(Console.ReadLine());
                        intital++;
                    }

                    string reference = first + "-" + second;
                    _scriptures.Add(new Scripture(book, reference, verses));
                }
                else if (verse_count == 0) // There is only one verse to check
                {
                    Console.WriteLine($"Enter in the Verse");
                    verse = Console.ReadLine();
                    _scriptures.Add(new Scripture(book, first, verse));
                }
            }
            else if (direction == "4") // Save a Scripure
            {
                Console.WriteLine("What is the name of the file you wish to save too?");
                save(ref _scriptures, Console.ReadLine());
            }
            else if (direction == "5") // Load a scripture
            {
                Console.WriteLine("What is the name of the file you wish to Load?");
                load(ref _scriptures, Console.ReadLine());
            }

        }
    }
    static void load(ref List<Scripture> _scriptures, string filename)
    {
        String line;
        List<string> buffer = new List<string>();
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
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                // Add to the buffer list
                buffer.Add(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.ReadLine();

            // Process the buffer

            string[] intitial = buffer[0].Split(':'); // split at the ':' mark of the reference
            if (intitial[1].Contains('-'))// Are there muitiple verses?
            {
                string[] verse_length = intitial[1].Split('-');

                string reference =  verse_length[0] + "-" + verse_length[1];
                _scriptures.Add(new Scripture(intitial[0], reference, buffer));
            }
            else
            {
                try
                {
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                
            }
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
    
    static void save(ref List<Scripture> _scriptures, string filename)
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
            
            foreach (Scripture item in _scriptures) // Get every scripture
            {
                sw.WriteLine(item.getReference()); // Write the reference
                foreach(Verse verse in item.getVerses()) // Get each verse in that scripture
                {
                    foreach (Word write in verse.getWord()) // Start writing each word to the file
                    {
                        sw.Write(write.getWord());
                    }
                    sw.Write("\n");
                }
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
}