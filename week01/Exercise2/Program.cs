using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string stringGrade = Console.ReadLine();
        int intGrade = int.Parse(stringGrade);
        string letter = "";
        if (intGrade >= 90)
        {
            letter = "A";
        }
        else if (intGrade >= 80 && intGrade < 90)
        {
            letter = "B";
        }
        else if (intGrade >= 70 && intGrade < 80)
        {
            letter = "C";
        }
        else if (intGrade >= 60 && intGrade < 70)
        {
            letter = "D";
        }
        else if (intGrade < 60)
        {
            letter = "F";
        }
        if (stringGrade.Length > 1)
        {
            if (int.Parse(stringGrade.Substring(1)) >= 7 && letter != "A" && letter != "F")
            {
                letter += "+";
            }
            else if (int.Parse(stringGrade.Substring(1)) <= 3 && letter != "F")
            {
                letter += "-";
            }
        }
        Console.WriteLine($"{letter}");
        if (intGrade >= 70)
        {
            Console.Write("You passed!");
        }
        else
        {
            Console.Write("Better luck next time!");
        }
    }
}