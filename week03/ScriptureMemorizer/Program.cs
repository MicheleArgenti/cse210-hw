using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Console.Clear();
        while (!scripture.IsCompletlyhidden())
        {
            Console.WriteLine(reference.GetDisplayText() + " " + scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string check = Console.ReadLine();
            if (string.IsNullOrEmpty(check))
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 4);
                scripture.HideRandomWords(randomNumber);
            }
            else if (check == "quit")
            {
                break;
            }
            Console.Clear();
        }

    }
}