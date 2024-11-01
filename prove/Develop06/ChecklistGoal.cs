public class ChecklistGoal : Goal
{
    private int targetCount;
    protected int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    public int CurrentCount
    {
        get {
            return currentCount;
        }
        set {
            currentCount = value;
        }
    }
    public int TargetCount { get; set; }
    public int BonusPoints { get; set; }


    public override void RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            if (currentCount == targetCount)
            {
                isComplete = true;
                points += bonusPoints;
            }
        }
    }

    public override string GetDetailsString()
    {
        return $"{name} (Checklist) - Progress: {currentCount}/{targetCount}, Points: {points}, Completed: {isComplete}";
    }
}
