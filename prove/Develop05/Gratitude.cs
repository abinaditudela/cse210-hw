using System;
using System.Threading;

public class Gratitude : Activity
{
    private List<string> _gratitudePrompts = new List<string> 
    {
        "Think of a person you're grateful for.",
        "Think of a skill you're grateful to have learned.",
        "Think of a memory that makes you smile.",
        "Think of something in your surroundings you're grateful for."
    };

    public Gratitude() : base("Gratitude Activity") {}

    public void Run()
    {
        StartMessage("This activity will help you reflect on things you're grateful for in your life.");
        int duration = GetDuration();
        
        while (duration > 0)
        {
            Console.WriteLine(GetRandomPrompt());
            Thread.Sleep(3000); // Pause to reflect on gratitude
            duration -= 10; // Assume 10 seconds of reflection per gratitude prompt
        }

        EndMessage("Well done! You have completed the gratitude exercise.");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_gratitudePrompts.Count);
        return _gratitudePrompts[index];
    }
}
