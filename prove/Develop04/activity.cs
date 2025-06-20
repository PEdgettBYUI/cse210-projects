using System.ComponentModel.DataAnnotations;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _end;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well Done!\n You've completed {_duration} seconds of the {_name} Activity");
    }
}