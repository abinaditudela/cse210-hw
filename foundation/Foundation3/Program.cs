using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity runnin, cycling and swimming
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 45, 15.0);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 20, 30);

        // Store each activity in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summary for all activities
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

