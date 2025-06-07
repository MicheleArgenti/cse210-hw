using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        do
        {
            Console.Write("Menu option: \n    1. Start breathing activity \n    2. Start reflecting activity \n    3. Start listing activity \n    4. Quit \nSelect a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    BreatingActivity breatingActivity = new BreatingActivity("Breating", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                    breatingActivity.Run();
                    break;
                case 2:
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
                    reflectingActivity.Run();
                    break;
                case 3:
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                    listingActivity.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Option not valid.");
                    break;
            }
            Console.Clear();

        } while (userChoice != 4);
    }
}
