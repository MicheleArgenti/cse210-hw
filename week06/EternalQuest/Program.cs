using System;

class Program
{
    /* 
      To show creativity I added the user's level by dividing the total score by 100.
      You can find the method GetLevel() in the GoalManager class.
    */
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int userChoice = 0;
        do
        {
            goalManager.Start();
            userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;
                case 2:
                    goalManager.ListGoals();
                    break;
                case 3:
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Exiting.");
                    break;
                default:
                    Console.WriteLine("Wrong Number.");
                    break;
            }
        } while (userChoice != 6);
    }

}