public class Scripture
{
    //Member variables private with data type of the other two classes.
    //The Reference and a list of Word
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //Constructor for the Scripture object. The first part in the
    //reference as a Reference class and a string text tha is the
    //scripture later converted in a list of Word
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        //Convert the string into a list, loop to construct a Word object
        //with each word in the list and add it to the _words list
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    //Methods to HideRandomWords, GetDisplayText string and to know if the
    //Scripture IsCompletelyHidden
    public void HideRandomWords()
    {

    }
    public string GetDisplayText()
    {
        string displayText = "";
        //Loop to iterate through all Word objects and create the string
        foreach (Word word in _words)
        {
            displayText = displayText + word.GetDisplayText() + " ";
        }
        displayText = displayText + _reference.GetDisplayText();
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        //IsCompletelyHidden, so it's true
        return true;
    }
}