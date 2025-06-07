public class ReflectingActivity : Activity
{
    private List<String> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<String> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt: \n");
        DisplayPrompt();
        Console.Write("\nWhen you have somenthing in mind, press enter to continue. ");
        string check = Console.ReadLine();
        Console.Write("You main begin in: ");
        ShowCountDown(5);
        Console.Clear();
        while (_duration > 0)
        {
            DisplayQuestions();
            ShowSpinner(10);
            _duration -= 10;
        }
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(0, _prompts.Count());
        return _prompts[randomPrompt];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomQuestion = random.Next(0, _questions.Count());
        string result = _questions[randomQuestion];
        _questions.Remove(result);
        return result;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"\n    -- {GetRandomPrompt()} --");
    }

    public void DisplayQuestions()
    {
        Console.Write($"\n{GetRandomQuestion()} ");
    }
}