class Word
{
    private string _word;
    private bool _hidden;


    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }



    public bool IsHidden()
    {
        return _hidden;
    }

    public void ToggleIsHidden(bool hidden)
    {
        if (hidden == true)
            _hidden = false;
        else if (hidden == false)
            _hidden = true;
    }

    // 
    public string GetWordString()
    {
        return _word;
    }

    public void DisplayWord()
    {
        int wordlength = GetWordLength();

        if (_hidden == true)
        {
            Console.Write(new string('_', wordlength));
        }
        else
        {
            Console.Write($"{_word} ");
        }
    }

    private int GetWordLength()
    {
        int letterCount = _word.Length;
        return letterCount;
    }
}