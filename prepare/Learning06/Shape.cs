// Shape.cs
public class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return this.color;
    }

    public virtual double GetArea()
    {
        return 0; // Default implementation (can be overridden in derived classes)
    }
}
