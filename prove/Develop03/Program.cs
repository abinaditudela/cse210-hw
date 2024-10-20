using System;

class Program
{
    static void Main(string[] args)
    {
                // Create the reference for the scripture
        Reference reference = new Reference("John", 3, 16);

        // Scripture text
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

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