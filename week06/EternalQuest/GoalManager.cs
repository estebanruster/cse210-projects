//using System.IO;

//Class that manage the Goals, menu and user score
public class GoalManager
{
    //private member variables unique to the GoalManager; the user score
    //and the list of Goals
    private int _score;
    private List<Goal> _goals;

    //GoalManager constructor; sets score to 0 and initialize an empty
    //Goal list
    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    //Class methods for the menu itself, to help display user info,
    //display Goals info, Load and Save files with the Goals info, create
    //Goals and to call the Events of the Goals
    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {

    }
    public void DisplayGoalsInfo()
    {

    }
    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            outputfile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputfile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        //file divided by lines into an array
        string[] lines = File.ReadAllLines(fileName);

        //Index 0 (first line) has the score
        _score = int.Parse(lines[0]);

        //for loop to iterate through all the goals
        for (int i = 1; i < lines.Length; i++)
        {
            //Lines splited by ':'; index 0 of parts1 contains string of
            //the type of Goal (the object of the derived class)
            string[] parts1 = lines[i].Split(":");
            if (parts1[0] == "SimpleGoal")
            {
                string parts2 = parts1[1];
                string[] forConstructor = parts2.Split("|");
                SimpleGoal simpleGoal = new SimpleGoal(forConstructor[0], forConstructor[1], forConstructor[2], bool.Parse(forConstructor[3]));
                _goals.Add(simpleGoal);
            }
            else if (parts1[0] == "EternalGoal")
            {
                string parts2 = parts1[1];
                string[] forConstructor = parts2.Split("|");
                EternalGoal eternalGoal = new EternalGoal(forConstructor[0], forConstructor[1], forConstructor[2]);
                _goals.Add(eternalGoal);
            }
            else if (parts1[0] == "ChecklistGoal")
            {
                string parts2 = parts1[1];
                string[] forConstructor = parts2.Split("|");
                ChecklistGoal checklistGoal = new ChecklistGoal(forConstructor[0], forConstructor[1], forConstructor[2], int.Parse(forConstructor[3]), int.Parse(forConstructor[4]), int.Parse(forConstructor[5]));
                _goals.Add(checklistGoal);
            }
        }
    }
}