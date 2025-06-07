using System.Diagnostics;
public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the dollowing prompt: ");
        GetRandomPrompt();
        Console.Write("You main begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        while (_duration > 0)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.Write("> ");
            string input = Console.ReadLine();
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            _duration -= (int)elapsed.TotalSeconds;
            _count++;
        }
        Console.WriteLine($"You have listed {_count} items.");
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomPrompt]);
    }

    public List<string> GetFromUser()
    {
        return [];
    }
}