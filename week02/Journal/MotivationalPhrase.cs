public class MotivationalPhrase
{
    List<string> _phrase = new List<string>
    {
        "Your journal is a mirror to your soul - write honestly and watch yourself grow.",
        "One sentence today becomes a thousand insights tomorrow.",
        "Future you will thank present you for these pages.",
        "There are no wrong words here - only unfiltered truth.",
        "Every entry is a step toward understanding yourself better."
    };

    public string GetRandomPhrase()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _phrase.Count());
        return _phrase[randomNumber];
    }
}