using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Display method
    public void Display()
    {
        // Print the person's name
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job in the list
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
