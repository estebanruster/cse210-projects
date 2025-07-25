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
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted < _target)
        {
            return int.Parse(GetPoints());
        }
        else if (_amountCompleted == _target)
        {
            return int.Parse(GetPoints()) + _bonus;
        }
        else
        {
            _amountCompleted = _target;
            Console.WriteLine("Target reached; no more events can be recorded");
            return 0;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        return $"{GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}";
    }
}