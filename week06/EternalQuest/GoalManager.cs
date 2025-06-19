//using System.IO;

//Class that manage the Goals, menu and user score
using System.ComponentModel.Design;

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
        string menu;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Console.ReadLine();
            if (menu == "1")
            {
                CreateGoal();
            }
            else if (menu == "2")
            {
                DisplayGoalsInfo();
            }
            else if (menu == "3")
            {
                SaveGoals();
            }
            else if (menu == "4")
            {
                LoadGoals();
            }
            else if (menu == "5")
            {
                RecordEvent();
            }
            else if (menu == "6")
            {
                Console.WriteLine("Exiting program. See ya!");
            }
            else
            {
                Console.WriteLine("Invalid input. Select a number choice from the menu.");
            }
        } while (menu != "6");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    public void DisplayGoalsInfo()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            //Checks for completion to display mark [X] or not
            if (goal.IsComplete() == true)
            {
                Console.WriteLine($"{_goals.IndexOf(goal) + 1}. [X] {goal.GetDetailsString()}");
            }
            else if (goal.IsComplete() == false)
            {
                Console.WriteLine($"{_goals.IndexOf(goal) + 1}. [ ] {goal.GetDetailsString()}");
            }
        }
    }
    public void CreateGoal()
    {
        //Type of goals sub menu. It creates the aproriate object and adds
        //it to the List<Goal>
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalMenu = Console.ReadLine();
        if (goalMenu == "1")
        {
            Console.Write("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string description = Console.ReadLine();
            Console.Write("How many points this goal would give? ");
            string points = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);
            _goals.Add(simpleGoal);
        }
        else if (goalMenu == "2")
        {
            Console.Write("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string description = Console.ReadLine();
            Console.Write("How many points this goal would give? ");
            string points = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalMenu == "3")
        {
            Console.Write("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.Write("What is the description of the goal? ");
            string description = Console.ReadLine();
            Console.Write("How many points this goal would give? ");
            string points = Console.ReadLine();
            Console.Write("How many bonus points this goal would give at completion? ");
            int bonus = int.Parse(Console.ReadLine());
            Console.Write("How many times this goal need to be accomplished for completion? ");
            int target = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, bonus, target);
            _goals.Add(checklistGoal);
        }
        //If user input is anything else, display message and return to
        //main menu
        else
        {
            Console.WriteLine("Invalid input. Returning to main menu.");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetShortName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int recordMenu = int.Parse(Console.ReadLine());
        int wonPoints = _goals[recordMenu - 1].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {wonPoints} points!");
        _score += wonPoints;
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        //Using code, to open and close file
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
        _goals.Clear();
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