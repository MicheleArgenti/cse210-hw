public class PromptGenerator
{
    List<string> _prompts = new List<string>
    {
        "What are three things I'm grateful for today?",
        "What is one lesson I've learned recently that changed my perspective?",
        "What does my ideal day look like",
        "What is a fear I'd like to overcome, and what's the first step",
        "If I could give my younger self one piece of advice, what would it be"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count());
        return _prompts[randomNumber];
    }
}