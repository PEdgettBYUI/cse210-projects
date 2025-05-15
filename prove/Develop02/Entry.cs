class Entry
{
    private string e_date;
    private string e_prompt;
    private string e_response;


    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today ?",
        "If I had one thing I could do over today, what would it be?",
        "What's one new thing you learned today?",
        "What's something productive you've done today?",
        "What's something you read/watched today?",
        "Did you see anyone interesting today?"
    };

    public void setEDate()
    {
        DateTime currentDate = DateTime.Now;    // retrieves in format (y/m/d)
        string dateAsString = currentDate.ToString("MMMM dd, yyyy");
        e_date = dateAsString;
    }

    public void dailyPrompt()
    {
        Random randomQuestion = new Random();
        string chosenPrompt = prompts[randomQuestion.Next(prompts.Count)];
        e_prompt = chosenPrompt;
        // Console.WriteLine(chosenPrompt);
    }

    public void recordResponse()
    {
        e_response = Console.ReadLine();
    }

    public string formEntryLine()
    {
        string outputString = "";
        outputString = $"({e_date}#{e_prompt}#{e_response})";
        Console.WriteLine(outputString);
        return outputString;
    }

    // public void showDate()
    // {
    //     Console.WriteLine(e_date);
    // }

}