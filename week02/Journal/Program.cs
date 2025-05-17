/* 
    Streatch Challenge:
        - added an option to the program. The option is now number 6, and it returns a motivational phrase to write the journal.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();
        string options = "Please select one of the following option\n1. Write\n2. Display\n3. Load\n4. Save\n5. Motivational Phrase\n6. Quit\nWhat would you like to do? ";
        int userChoice = 0;
        while (userChoice != 6)
        {
            Console.Write(options);
            userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Entry entry = new Entry();
                    string promptText = prompt.GetRandomPrompt();
                    Console.WriteLine(promptText);
                    string phrase = Console.ReadLine();
                    entry._entryText = phrase;
                    entry._date = "" + DateTime.Now;
                    entry._promptText = promptText;
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("What is the name of the file? ");
                    string fileToLoadFrom = Console.ReadLine();
                    journal.LoadFromFile(fileToLoadFrom);
                    break;
                case 4:
                    Console.Write("What is the name of the file? ");
                    string fileToSaveTo = Console.ReadLine();
                    journal.SaveToFile(fileToSaveTo);
                    break;
                case 5:
                    MotivationalPhrase motivationalPhrase = new MotivationalPhrase();
                    Console.Write(motivationalPhrase.GetRandomPhrase());
                    break;
                case 6:
                    Console.Write("Exiting.");
                    break;
                default:
                    Console.Write("Option not valid.");
                    break;
            }
        }
    }
}