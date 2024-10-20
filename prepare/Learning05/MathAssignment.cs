public class MathAssignment : Assignment
{
    // Private  variables to MathAssignment
    private string _textbookSection;
    private string _problems;

    // Constructor 
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to return the homework details (textbook section and problems)
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
