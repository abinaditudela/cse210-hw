public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override string GetDetailsString()
    {
        return $"{name} (Simple) - Points: {points}, Completed: {isComplete}";
    }
}
