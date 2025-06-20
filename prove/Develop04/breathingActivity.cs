class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
    : base(name, description) { }

    public void RunBreathingActivity()
    {
        DisplayWelcome();
        ObtainDurationFromUser();
        RunTimer("Get Ready... ", 3);
        SetEndTime();

        // Breath in/out
        while (!HasTimerExpired())
        {
            RunTimer("\nBreath in...", 6);
            // DominoAnimation();
            RunTimer("\nBreath out...", 4);
            // DominoAnimation();
        }
        DisplayEndMessage();
        DominoAnimation();
    }
}