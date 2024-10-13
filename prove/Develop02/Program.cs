using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string[] prompts = 
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("\n   Abinadi's Journal Menu");
            Console.WriteLine("1. Write a new Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Random random = new Random();
                string prompt = prompts[random.Next(prompts.Length)];
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                
                Entry entry = new Entry(prompt, response);
                journal.AddEntry(entry);
            }
            else if (option == "2")
            {
                journal.DisplayEntries();
            }
            else if (option == "3")
            {
                Console.Write("Enter the filename to save the journal: ");
                string filename = Console.ReadLine();
                journal.SaveJournal(filename);
            }
            else if (option == "4")
            {
                Console.Write("Enter the filename to load the journal: ");
                string filename = Console.ReadLine();
                journal.LoadJournal(filename);
            }
            else if (option == "5")
            {
                break;
            }
        }
    }
}
