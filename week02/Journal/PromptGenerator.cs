/*
Author: Esteban Rubén Mangas Calva
W02 Project: Journal Program
PromptGenerator class code
*/
public class PromptGenerator
{
    //Member variable prompts list
    public List<string> _prompts = new List<string>();

    //Get Random Prompt method. This method returns a prompt (string);
    //because it is later used and saved in the Entry class.
    public string GetRandomPrompt()
    {
        //Random class instance created
        Random randomGenerator = new Random();
        //Creating a list with the prompts
        _prompts.Add("What was the strongest emotion I felt today and why?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What is one thing I could learn from today?");
        _prompts.Add("Who was the most interesting person I interacted with today and why?");
        _prompts.Add("For what are you grateful today and why?");
        _prompts.Add("What was the funniest thing that happened today?");
        //Instance used to get the next integer between 0 to 5 of the list index
        int randomIndex = randomGenerator.Next(0, 6);
        Console.WriteLine(randomIndex);
        return _prompts[randomIndex];
    }
}