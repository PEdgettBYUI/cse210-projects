class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;


    public Scripture(string name, int chapter, int verse, string text)
    {
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word aWord = new Word(word);
        }
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        
    }

    public Scripture(ScriptureReference ref, string text)
    {

    }



    public bool HideSomeWords()
    {

    }

    public void ShowScripture()
    {

    }

    public string GetScriptureReference()
    {

    }

    private int NumberOfHiddenWords()
    {

    }

    private List<Word> ConvertToWords()
    {

    }
}