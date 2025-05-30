using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a list of video
        List<Video> videos = new List<Video>();
        // Creating 3 videos
        videos.Add(new Video("How to cook lasagna", "Easy Coocking", 600));
        videos.Add(new Video("Climb Mount Everest", "Adventure With Us", 1200));
        videos.Add(new Video("How to remember everything in a few seconds", "Open Mind", 600));
        // Adding 3 comments to each videos
        videos[0].AddComment(new Comment("Ethan Carter", "Thank you for sharing your recipe!"));
        videos[0].AddComment(new Comment("Lucas Bennett", "Amazing!"));
        videos[0].AddComment(new Comment("Nathaniel Graves", "Finally I learned how to cook lasagna. Thank you so much."));
        videos[1].AddComment(new Comment("Sophia Delacroix", "I want to travel with you!"));
        videos[1].AddComment(new Comment("Isabella Montague", "There is an amazing view over there."));
        videos[1].AddComment(new Comment("Olivia Sinclair", "I'm going to climb it too next week!"));
        videos[2].AddComment(new Comment("Taylor Winslow", "Now I will not fail any class."));
        videos[2].AddComment(new Comment("Jordan Ashford", "You opened my mind."));
        videos[2].AddComment(new Comment("Riley Chamberlain", "Thank you for your help!"));
        // Calling some methods for each video
        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayVideo());
            Console.WriteLine($"The total comments are: {video.GetNumberComments()}");
            Console.WriteLine(video.DisplayComment());
        }
    }
}