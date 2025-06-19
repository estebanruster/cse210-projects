public class ChecklistGoal : Goal
{
    //Private member variables unique to this class
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constructor for the class; calling base constructor to avoid error
    //systems. Setting approriate values to its unique member variables
    public ChecklistGoal(string shortName, string description, string points, int bonus, int target) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    //Second constructor to create the object when it is loaded from a file
    public ChecklistGoal(string shortName, string description, string points, int bonus, int target, int amountCompleted) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    //Override methods from the abstract ones and the virtual one
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}