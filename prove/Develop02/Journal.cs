class Journal
{
    public string journalName;
    private string newEntryData;
    private List<string> Entries = new List<string>();


    public void SaveEntry()
    {
        // Saves the current entry into the list of entries
        // Takes Entry (obj.) and takes {date}#{prompt}#{response} as a single string and adds it to the Journal's .txt file.
    }

    public void LoadJournal()
    {
        // Takes a given {name}.txt file and breaks it down line by line into multiple Entry (obj.) by breaking each line down.
    }

    public void DisplayJournal()
    {
        // Displays all entries in the Entries List when left blank
        // OR shows the contents of a specific journal entry
    }
}