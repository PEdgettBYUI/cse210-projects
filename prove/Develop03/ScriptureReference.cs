class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int[] _verse;


    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = new int[] {verse};
    }

    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = new int[] {startVerse, endVerse};
    }



    public void ShowScriptureReference()
    {

    }

    public string GetScriptureReference()
    {

    }

    private string GetScriptureReferenceString()
    {

    }
}