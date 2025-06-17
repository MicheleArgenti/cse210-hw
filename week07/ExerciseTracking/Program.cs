using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(15, "17 Jun 2025", 30),
            new Cycling(30, "17 Jun 2025", 25),
            new Swimming(10, "17 Jun 2025", 10),
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}