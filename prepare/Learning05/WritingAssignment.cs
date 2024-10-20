public class WritingAssignment : Assignment
{
    // Private member variable specific to WritingAssignment
    private string _title;

    // Constructor that accepts parameters for all details and calls the base constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Method to return the writing information (title and student name)
    public string GetWritingInformation()
    {
        // Access the student name using the getter from the base class
        return $"{_title} by {GetStudentName()}";
    }
}
