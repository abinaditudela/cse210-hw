using System;
/*
Adan Abinadi Tudela Cabero
This program exceeds the core requirements by:
1. Adding a new Gratitude Activity that encourages users to reflect on things they're grateful for.
2. Ensuring that no prompts or questions are repeated within a session until all have been used.
3. Enhancing the breathing exercise with a meaningful animation that simulates breathing through expanding and contracting text.
*/

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("____________________");
            Console.WriteLine("                    ");
            Console.WriteLine("    MINDFULNESS  \n  ");
            Console.WriteLine(" 1. Breathing");
            Console.WriteLine(" 2. Reflection");
            Console.WriteLine(" 3. Listing");
            Console.WriteLine(" 4. Gratitude");
            Console.WriteLine(" 5. Quit");
            Console.WriteLine("____________________");
            Console.Write(" \nChoose an activity: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing breathing = new Breathing();
                breathing.Run();
            }
            else if (choice == "2")
            {
                Reflection reflection = new Reflection();
                reflection.Run();
            }
            else if (choice == "3")
            {
                Listing listing = new Listing();
                listing.Run();
            }
            else if (choice == "4")
            {
                Gratitude gratitude = new Gratitude();
                gratitude.Run();
            }
            else if (choice== "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine();
        }
    }
}
