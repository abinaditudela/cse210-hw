using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing() : base("Breathing Activity") {}

    public void Run()
    {
        StartMessage("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int duration = GetDuration();
        
        while (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            AnimatedText("In.", 4); // New breathing animation
            Console.WriteLine("Breathe out...");
            AnimatedText("Out.", 6); // New breathing animation
            duration -= 10; // Each in-out cycle takes 10 seconds
        }

        EndMessage("Well done! You have completed the breathing exercise.");
    }
    private void AnimatedText(string text, int seconds)
{
    int totalSteps = seconds * 10; // Simulate a finer-grained animation
    for (int i = 1; i <= totalSteps; i++)
    {
        int dots = i % 3 + 1;
        Console.Write($"\r{text}{new string('.', dots)}");
        Thread.Sleep(100); // Gradually slow down the text to simulate breathing
    }
    Console.WriteLine();
}
}
