public class Word
{
    //Member variables private; one for the string of the Word and other
    //for the bool of the Hidden condition
    private string _text;
    private bool _isHidden;

    //Constructor for the Word object. Accepts a string for the text and
    //set bool to false
    public Word(string text)
    {
        _text = text;
        //Is Hidden? False (no). So it is shown
        _isHidden = false;
    }

    //Methods for the Word class to Hide or Show the Word (these changes
    //the bool), IsHidden to return the bool value and GetDisplayText to
    //return the string to display the word or the blank (show or hide)
    public void Hide()
    {

    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return "";
    }
}