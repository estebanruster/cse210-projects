/*
Author: Esteban Rubén Mangas Calva
W02 Project: Journal Program
Entry class code
*/
public class Entry
{
    //Creating the member variables _prompt, _entry and _dateText
    public string _prompt = "";
    public string _entry = "";
    public string _dateText = "";

    //DisplayEntry method to display Entry with the member variables and
    // format, to later use in the DisplayAll method of Journal class
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_dateText} - Prompt: {_prompt}");
        Console.WriteLine(_entry);
        Console.WriteLine();
    }
}