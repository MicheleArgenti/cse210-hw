public class BreatingActivity : Activity
{
    public BreatingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        while (_duration > 0)
        {
            Console.Write("\nBreath in...");
            ShowCountDown(4);
            _duration -= 4;
            if (_duration == 0)
                break;
            Console.Write("\nNow breath out...");
            ShowCountDown(6);
            _duration -= 6;
        }
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}