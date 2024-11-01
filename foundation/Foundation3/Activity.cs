using System;

public abstract class Activity
{
    protected DateTime date;
    protected int duration; // in minutes

    protected Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    // Properties set and get
    public DateTime Date => date;
    public int Duration => duration;

    // Abstract methods for derived classes to override
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Common summary format for all activities
    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({duration} min): Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}

