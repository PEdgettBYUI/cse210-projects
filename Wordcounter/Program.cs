class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Word Counter!");

        WordCounter wordCounter = new WordCounter("If only there was more gravy in my pie. It's rather dry without the gravy.");

        wordCounter.DisplayWords();
    }
}