
public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // Each lap is 50 meters, converting to miles
        return laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / duration) * 60;
    }

    public override double GetPace()
    {
        return duration / GetDistance();
    }
}
