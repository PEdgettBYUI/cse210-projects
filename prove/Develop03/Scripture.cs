class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;


    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(name, chapter, verse);
        _words = new List<Word>();

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word aWord = new Word(word);
            _words.Add(aWord);
        }
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(name, chapter, startVerse, endVerse);
        _words = new List<Word>();

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word aWord = new Word(word);
            _words.Add(aWord);
        }
    }

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word aWord = new Word(word);
            _words.Add(aWord);
        }
    }


    // public bool HideSomeWords()
    // {

    // }

    public void ShowScripture()
    {
        _reference.ShowScriptureReference();

        Console.WriteLine();

        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
    }

    public string GetScriptureReference()
    {
        string refferal = _reference.GetScriptureReference();

        return _ref;

    }

    // private int NumberOfHiddenWords()
    // {

    // }

    // private List<Word> ConvertToWords()
    // {
        
    // }
}