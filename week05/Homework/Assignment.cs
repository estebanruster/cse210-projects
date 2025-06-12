public class Assignment
{
    //Making private member variables for the base class
    private string _studentName;
    private string _topic;

    //Constructor for the base class that receives strings for both
    //member variables
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Making GetSummary method for the base class; returns a string with
    //both member variables strings
    public string GetSummary()
    {
        return $"Students name: {_studentName}\nTopic: {_topic}";
    }

    //To still make it encapsulated, GetStudentName method to get
    //_studentName for WritingAssignment class created

    public string GetStudentName()
    {
        return _studentName;
    }
}