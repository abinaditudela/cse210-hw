using System;

class Program
{
    static void Main(string[] args)
    {
                // Create the reference for the scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Scripture text
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        // Create the scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Check if scripture is completely hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            // Hide random words
            scripture.HideRandomWords(3); // Hide 3 random words
        }
        Console.WriteLine("Goodbye!");
    }
}