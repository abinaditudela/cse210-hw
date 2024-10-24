using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base("Listing Activity") {}

    public void Run()
    {
        StartMessage("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        int duration = GetDuration();
        
        DisplayPrompt();
        List<string> items = GetListFromUser(duration);

        Console.WriteLine($"You listed {items.Count} items.");
        EndMessage("Well done! You have completed the listing exercise.");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Thread.Sleep(2000); // Pause for the user to think
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        return items;
    }
}
