using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Add Goal\n2. Record Event\n3. Display Goals\n4. Save Goals\n5. Load Goals\n6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    Console.Write("Enter goal number to record event: ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex))
                    {
                        goalManager.RecordEvent(goalIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.SaveGoals("goals.txt");
                    break;
                case "5":
                    goalManager.LoadGoals("goals.txt");
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
