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
    }

    //Methods to select from the list random prompts and questions, to
    //display them and to run this activity
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestions()
    {
        return "";
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        /*
        for (int i = 0; i < _time; i++)
        {

        }
        */
        Console.WriteLine(GetRandomQuestions());
    }
}