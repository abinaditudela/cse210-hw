using System;
using System.Threading;

public class Activity
{
    private string _message;
    private int _seconds;
    private string _activityName;

    public Activity(string activityName)
    {
        _activityName = activityName;
    }

    public string StartMessage(string message)
    {
        _message = message;
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}: \n{message}");
        Console.Write("Enter the duration of the activity in seconds: ");
        _seconds = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000); // 2 second pause
        return _message;
    }

    public string EndMessage(string message)
    {
        _message = message;
        Console.WriteLine($"{_activityName}: {message}");
        Console.WriteLine($"You have completed {_activityName} for {_seconds} seconds.");
        Console.Write("\nPress any key to continue...");
        Console.ReadKey();
        return _message;
    }

    public void CountDownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // 1 second per countdown tick
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _seconds;
    }
}
