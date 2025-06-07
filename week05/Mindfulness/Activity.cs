public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    private int _totalDuration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        _totalDuration = _duration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!\n");
        Console.WriteLine($"You have completed another {_totalDuration} seconds of the {_name} Activity.");
    }

    public void ShowSpinner(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            seconds -= 1;
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            seconds -= 1;
        }
    }

    public void ShowCountDown(int seconds)
    {
        if (_duration < seconds)
            seconds = _duration;
        while (seconds > 0)
        {
            Console.Write($"{seconds}");
            seconds -= 1;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}