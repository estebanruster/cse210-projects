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
        int numberToHide = 6;
        int lastIndex = _words.Count - 1;
        int countShown = 0;
        int countHidden = 0;
        //Loop that counts and verify how many words are shown
        foreach (Word word in _words)
        {
            //bool hidden = word.IsHidden();
            if (word.IsHidden() == false)
            {
                countShown++;
            }
        }

        if (numberToHide < countShown)
        {
            while (countHidden != numberToHide)
            {
                //Random class instance created
                Random randomGenerator = new Random();
                //Instance used to get the next integer between the indexes of the List<Word>
                int indexToHide = randomGenerator.Next(0, lastIndex);
                //Condition to Hide only random words shown
                if (_words[indexToHide].IsHidden() == false)
                {
                    _words[indexToHide].Hide();
                    countHidden++;
                }
            }
        }
        else if (numberToHide >= countShown)
        {
            foreach (Word word in _words)
            {
                if (word.IsHidden() == false)
                {
                    word.Hide();
                }
            }
        }
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
        int wordTotal = _words.Count;
        int countHidden = 0;
        bool completelyHidden = false;
        //Loop to check if every word is hidden
        foreach (Word word in _words)
        {
            //bool hidden = word.IsHidden();
            if (word.IsHidden() == true)
            {
                countHidden++;
            }
        }
        if (countHidden == wordTotal)
        {
            completelyHidden = true;
        }
        //IsCompletelyHidden, so it's true
        return completelyHidden;
    }
}