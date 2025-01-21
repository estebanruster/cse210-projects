//code for the Job class
public class Job
{
    //member variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    //method (member function) to display job details
    public void DisplayJobDetails ()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}