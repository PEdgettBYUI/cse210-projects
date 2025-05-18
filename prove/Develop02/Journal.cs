class Journal
{
    // Copy of the filename used for the journal; Current Use Case Undecided.
    public string journalName;
    // Stores a list of all entries from the journal(.txt)
    private List<Entry> Entries = new List<Entry>();
    // Adds a given Entry object to the current Journal
    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }
    // Retrieves list for use from the menu
    public List<Entry> EntriesList
    {
        get { return Entries; }
    }



    // Checks if the journal has a name, if it doesn't, prompts the user to create one
    public void nameJournal()
    {
        if (string.IsNullOrEmpty(journalName))
        {
            Console.WriteLine("Please give your Journal a name: ");
            journalName = Console.ReadLine() + ".txt";

            Console.WriteLine($"[Journal Created: {journalName}]");

            // This will create the file if it doesn't exist, or overwrite if it does
            using (FileStream fs = File.Create(journalName))
            {

            }
        }
    }

    // Create a new Entry and Add it to list<>Entries
    public void CreateAndAddEntry()
    {
        Entry newEntry = new Entry();   // Create a new Entry object
        newEntry.NewEntry();            // Fill in the entry (date, prompt, response)
        AddEntry(newEntry);             // Add it to the Entries list
    }

    // Saves entries in Entries<> to a given filename
    public void SaveEntry(string filename, List<Entry> entries)
    {
        // Saves the current entry into the list of entries
        // Takes Entry (obj.) and takes {date}#{prompt}#{response} as a single string and adds it to the Journal's .txt file.
        if (Entries.Count != 0)
        {
            using (StreamWriter outputfile = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    outputfile.WriteLine(entry.convertEntryString());
                }
            }
        }
        else
        {
            Console.WriteLine("[NO Entries. SAVE Failed.]");
        }
    }

    // Loads a journal from a .txt; converts it into Entry format, and adds it to the current journal.
    public void LoadJournal(string filename)
    {
        // Takes a given {name}.txt file and breaks it down line by line into multiple Entry (obj.) by breaking each line down.
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry();
            entry.EntryFromFile(date, question, entryText);
            this.AddEntry(entry);
        }
        journalName = filename;
        Console.WriteLine("[LOAD complete!]\n");
    }

    // Displays all entries in the current Journal
    public void DisplayJournal()
    {
        // Displays File Name, as a reminder to the user
        if (string.IsNullOrEmpty(journalName))
        {
            Console.WriteLine("[NO NAME] Journal");
        }
        else
        {
            Console.WriteLine($"Journal: {journalName}\n\n");
        }

        // Displays every entry in an appealing format
        foreach (Entry item in Entries)
        {
            string EntryString = item.convertEntryString();
            Console.WriteLine(EntryString.Replace('#', '\n'));
            Console.WriteLine();
            // Displays all entries in the Entries List when left blank
            // OR shows the contents of a specific journal entry
        }
        Console.WriteLine($"--Total Entries: {Entries.Count}--\n");
        // Wait for User Input before Continuing
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();  //NOTE: Waits for input before continuing if BLANK
    }
}