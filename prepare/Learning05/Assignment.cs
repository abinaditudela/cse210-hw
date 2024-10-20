public class Assignment
{
    // Private variables
    private string _studentName;
    private string _topic;

    // Constructor 
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetTopic()
    {
        return _topic;
    }

    // Method to return the summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter method to access student name (since _studentName is private)
    public string GetStudentName()
    {
        return _studentName;
    }
}
