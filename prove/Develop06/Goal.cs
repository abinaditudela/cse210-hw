public abstract class Goal
{
    protected string name;
    protected int points;
    protected bool isComplete;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.isComplete = false;
    }
    public int Points
    {
        get 
        { 
            return points; 
        }

        set 
        { 
            points = value; 
        }
    }

    public string Name 
    { 
        get{return name;} 
        set { name = value;}
    }


    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public virtual bool IsComplete() => isComplete;
}
