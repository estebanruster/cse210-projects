public class WritingAssignment : Assignment
{
    //Making private member variables
    private string _title;

    //Making constructor for the variables in the base class and the one
    //in this. Calling the base class in the constructor to set the values
    //of the private member variables of the base
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    //GetWritingInformation method, return a string with the _title and
    //the _studentName
    public string GetWritingInformation()
    {
        return $"{_title} by {base.GetStudentName()}";
    }
}