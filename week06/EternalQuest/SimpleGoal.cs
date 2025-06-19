public class SimpleGoal : Goal
{
    //Private member variable unique to this class
    private bool _isComplete;

    //Constructor for the class; calling base constructor to avoid error
    //systems. Setting approriate values to its unique member variables
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    //Second constructor to create the object when it is loaded from a file
    public SimpleGoal(string shortName, string description, string points, bool isComplete) : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    //Override methods from the abstract ones
    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            return int.Parse(GetPoints());
        }
        else
        {
            Console.WriteLine("Goal acomplished; no more events can be recorded");
            return 0;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}