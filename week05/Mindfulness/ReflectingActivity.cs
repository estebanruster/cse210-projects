//Creating ReflectingActivity class as a derived class of Activity
public class ReflectingActivity : Activity
{
    //Member variables unique to ReflectingActivity
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    //Constructor that sets the value of the member variables
    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _time = 30;
        //Constructor populating the lists
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    //Methods to select from the list random prompts and questions, to
    //display them and to run this activity
    public void Run()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.Clear();
        DisplayQuestions();
    }
    public string GetRandomPrompt()
    {
        //Random class instance created
        Random randomGenerator = new Random();
        //Instance used to get the next integer between 0 to 3
        int randomIndex = randomGenerator.Next(0, 4);
        return _prompts[randomIndex];
    }
    public string GetRandomQuestions()
    {
        //Random class instance created
        Random randomGenerator = new Random();
        //Instance used to get the next integer between 0 to 8
        int randomIndex = randomGenerator.Next(0, 9);
        return _questions[randomIndex];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }
    public void DisplayQuestions()
    {
        //List created to save the prompts already passed
        List<string> repeated = new List<string>();
        string repeat;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        while (DateTime.Now < futureTime)
        {
            //This do while is for checking for repeated questions and
            //prevent to display them
            do
            {
                repeat = GetRandomQuestions();
            } while (repeated.Contains(repeat));
            repeated.Add(repeat);
            Console.Write($">{repeat}");
            ShowSpinner();
            Console.WriteLine();
            //The questions list has 9 elements. If repeated has the same
            //size, then repeated clears. So if the user entered a time for
            //the activity bigger enough to cicle through al the questions
            //and more, it will start again to give the previous questions
            if (repeated.Count == 9)
            {
                repeated.Clear();
            }
        }
    }
}