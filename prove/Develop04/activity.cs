using System.ComponentModel.DataAnnotations;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    private DateTime _endTime;

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
        Console.WriteLine($"\nWell Done!\n You've completed {_duration} seconds of the {_name} Activity");
    }

    public void RunTimer(string message, int duration)
    {
        // Demo of Decrementing Countdown
        int count = duration;

        Console.Write($"{message} ");
        while (count > 0)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }

    public void ObtainDurationFromUser()
    {
        Console.Write("How long do you want your session to be? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void SetEndTime()
    {
        DateTime currentTime = DateTime.Now;    // Unnecessary??
        _endTime = currentTime.AddSeconds(_duration);
    }

        public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void DominoAnimation()
    {
        int sleepTime = 200;
        int count = 7;

        // Simple "Domino" Loading Animation
        while (count > 0)
        {
            Console.Write("|");
            Thread.Sleep(sleepTime);  //in miliseconds
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("_");
            Thread.Sleep(sleepTime);
            // Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            count--;
        }
    }

}