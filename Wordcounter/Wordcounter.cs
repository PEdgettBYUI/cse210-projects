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
            Console.WriteLine($"   {word}");
        }

        Console.WriteLine($"\nThere are {count} words.\n");
    }

    public int CountSingleWord(string searchWord)
    {
        int count = 0;

        foreach (string word in _words)
        {
            if (word == searchWord) // NOTE: You can ignore adding the {} around the code in an if/else IF the output is only ONE STATEMENT (;)
                count++;
        }

        return count;
    }
}