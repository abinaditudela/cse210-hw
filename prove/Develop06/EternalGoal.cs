public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override void RecordEvent()
    {
        // Eternal goals never complete, only accumulate points
    }

    public override string GetDetailsString()
    {
        return $"{name} (Eternal) - Points: {points} (Accumulates on each record)";
    }
}
