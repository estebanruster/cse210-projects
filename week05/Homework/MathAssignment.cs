public class MathAssignment : Assignment
{
    //Making private member variables
    private string _textbookSection;
    private string _problems;

    //Making constructor for the variables in the base class and the ones
    //in this. Calling the base class in the constructor to set the values
    //of the private member variables of the base
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //GetHomeworkList method; return a string with _textbookSection and
    //_problems
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}