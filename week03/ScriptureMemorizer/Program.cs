/*
    Exceeding Requirements:
        - I implemented a List of Scripture. The program will choose a random scripture instead of using the same scripture
*/

using System;

class Program
{
    static List<Scripture> scriptures = new List<Scripture>();
    static void Main(string[] args)
    {
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture(new Reference("D&A", 115, 5), "Verily I say unto you all: Arise and shine forth, that thy light may be a standard for the nations;"));
        scriptures.Add(new Scripture(new Reference("Jhon", 15, 13), "Greater love hath no man than this, that a man lay down his life for his friends."));
        scriptures.Add(new Scripture(new Reference("Isaiah", 55, 8), "For my thoughts are not your thoughts, neither are your ways my ways, saith the Lord."));
        scriptures.Add(new Scripture(new Reference("3 Nefi", 12, 14, 16), "Verily, verily, I say unto you, I give unto you to be the light of this people. A city that is set on a hill cannot be hid. Behold, do men light a candle and put it under a bushel? Nay, but on a candlestick, and it giveth light to all that are in the house; Therefore let your light so shine before this people, that they may see your good works and glorify your Father who is in heaven."));
        Random random = new Random();
        int randomScripture = random.Next(0, scriptures.Count());
        do
        {
            Console.Clear();
            Console.WriteLine(scriptures[randomScripture].GetReference().GetDisplayText() + " " + scriptures[randomScripture].GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string check = Console.ReadLine();
            if (string.IsNullOrEmpty(check))
            {
                int randomNumber = random.Next(1, 4);
                scriptures[randomScripture].HideRandomWords(randomNumber);
            }
            else if (check.ToLower() == "quit")
            {
                return;
            }
        }
        while (!scriptures[randomScripture].IsCompletlyhidden());
        Console.Clear();
        Console.WriteLine(scriptures[randomScripture].GetReference().GetDisplayText() + " " + scriptures[randomScripture].GetDisplayText());
    }
}