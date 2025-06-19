//Base abstract class
public abstract class Goal
{
    //Private member variables common to derived classes
    private string _shortName;
    private string _description;
    private string _points;

    //Base constructor with parameters provided by the user in the
    //CreateGoal method of GoalManager
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    //Methods for the Goals
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return "";
    }
    public abstract string GetStringRepresentation();
}