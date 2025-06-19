//Base abstract class
public abstract class Goal
{
    //Private member variables common to derived classes
    private string _shortName;
    private string _description;
    private string _points;

    //Getters for the 

    //Base constructor with parameters provided by the user in the
    //CreateGoal method of GoalManager
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    //Getters methods to get the member variables from the base
    //class to the derived classes
    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetPoints()
    {
        return _points;
    }

    //Methods for the Goals
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}