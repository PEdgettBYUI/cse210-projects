class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Word Counter!");

        WordCounter wordCounter = new WordCounter("If only there was more gravy in my pie. It's rather dry without the gravy. Pie does so much better with gravy. If you could put all the pie in the gravy and then deep fry it, OOH! What a work of appeasement!");

        wordCounter.DisplayWords();

        int count_gravy = wordCounter.CountSingleWord("gravy");
        Console.WriteLine($"The word \"gravy\" appears {count_gravy} times.");


    }
}