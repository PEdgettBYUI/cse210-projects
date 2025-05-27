using System.Diagnostics.Metrics;

class WordCounter
{
    private List<string> _words;
    private int count;

    public WordCounter(string text)
    {
        _words = new List<string>();
        SplitIntoWords(text);
    }

    private void SplitIntoWords(string text)
    {
        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(word);
            count++;
        }
    }

    public void DisplayWords()
    {
        foreach (string word in _words)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine($"\n   There are {count} words.\n");

    }


}