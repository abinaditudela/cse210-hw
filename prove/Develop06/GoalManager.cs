using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals;
    private int totalPoints;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter the target count for the checklist goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing the checklist: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.RecordEvent();
            if (goal is SimpleGoal && goal.IsComplete())
            {
                totalPoints += goal.Points;
            }
            else if (goal is EternalGoal || (goal is ChecklistGoal checklistGoal && !checklistGoal.IsComplete()))
            {
                totalPoints += goal.Points;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(totalPoints); // Save total points
            foreach (Goal goal in goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"Simple|{simpleGoal.Name}|{simpleGoal.Points}|{simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    writer.WriteLine($"Eternal|{eternalGoal.Name}|{eternalGoal.Points}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"Checklist|{checklistGoal.Name}|{checklistGoal.Points}|{checklistGoal.CurrentCount}|{checklistGoal.TargetCount}|{checklistGoal.BonusPoints}");
                }
            }
        }
    }


    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            totalPoints = int.Parse(lines[0]);
            goals.Clear(); // Clear existing goals

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string goalType = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);

                if (goalType == "Simple")
                {
                    bool isComplete = bool.Parse(parts[3]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, points);
                    if (isComplete) simpleGoal.RecordEvent(); // Mark complete if saved as complete
                    goals.Add(simpleGoal);
                }
                else if (goalType == "Eternal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, points);
                    goals.Add(eternalGoal);
                }
                else if (goalType == "Checklist")
                {
                    int currentCount = int.Parse(parts[3]);
                    int targetCount = int.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                    checklistGoal.CurrentCount = currentCount; // Restore current progress
                    if (currentCount >= targetCount) checklistGoal.RecordEvent(); // Mark as complete if progress is done
                    goals.Add(checklistGoal);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

}
