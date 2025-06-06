using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Basics", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Very clear explanation!"));
        video1.AddComment(new Comment("Bob", "Thanks! This helped a lot."));
        video1.AddComment(new Comment("Charlie", "Can you make one on classes?"));
        videos.Add(video1);

        Video video2 = new Video("Top 5 Coding Mistakes", "DevTips", 450);
        video2.AddComment(new Comment("Dan", "Mistake #3 got me too!"));
        video2.AddComment(new Comment("Eve", "Useful tips!"));
        video2.AddComment(new Comment("Frank", "Thanks for sharing!"));
        videos.Add(video2);

        Video video3 = new Video("Unity Game Dev Intro", "GameGuru", 720);
        video3.AddComment(new Comment("Gina", "Excited to start!"));
        video3.AddComment(new Comment("Henry", "Very beginner-friendly."));
        video3.AddComment(new Comment("Ivy", "Subscribed!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments: ");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName}: {comment.GetText}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}