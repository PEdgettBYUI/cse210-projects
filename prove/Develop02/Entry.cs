class Entry
{
    private string _date;
    private string _prompt;
    private string _response;


// Used in conjunction with Journal.LoadJournal. Creates a new Entry with all the variables completed.
    public void ConstructEntry(string e_date, string e_prompt, string e_response)
    {
        _date = e_date;
        _prompt = e_prompt;
        _response = e_response;
    }

// List of Prompts. Add or remove items from it to expand possible prompts.
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

// Sets the Date for the current entry
    public void setDate()
    {
        DateTime currentDate = DateTime.Now;    // retrieves in format (y/m/d)
        string dateAsString = currentDate.ToString("MMMM dd, yyyy");
        _date = dateAsString;
    }

// Retrieves a prompt from the list of Prompts
    public void dailyPrompt()
    {
        Random randomQuestion = new Random();
        string chosenPrompt = prompts[randomQuestion.Next(prompts.Count)];
        _prompt = chosenPrompt;
        // Console.WriteLine(chosenPrompt);
    }

// Where the User records their Entry Response
    public void recordResponse()
    {
        _response = Console.ReadLine();
    }

//Turns the variables in a given Entry into a string with the format $"({_date}#{_prompt}#{_response})"
    public string formEntryLine()
    {
        string outputString = "";
        outputString = $"({_date}#{_prompt}#{_response})";
        Console.WriteLine(outputString);
        return outputString;
    }

    // public void showDate()
    // {
    //     Console.WriteLine(_date);
    // }

}