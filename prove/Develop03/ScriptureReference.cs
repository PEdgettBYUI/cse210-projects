using System.Runtime.CompilerServices;

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
        Console.Write($"{_bookName} {_chapter}:");

        if (_verse.Length == 1)
        {
            Console.Write($"{_verse[0]}");
        }
        else if (_verse.Length == 2)
        {
            Console.Write($"{_verse[0]} - {_verse[1]}");
        }
    }

    public string GetScriptureReference()
    {
        return GetScriptureReferenceString();
    }

    private string GetScriptureReferenceString()
    {
        string UH = $"{_bookName} {_chapter} {_verse}";

    }
}