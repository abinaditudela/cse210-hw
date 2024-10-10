public class Job
{
    // Member variables
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    //method to display
    public void Display()
    {
        // Print job details in the format "Job Title (Company) StartYear-EndYear"
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
