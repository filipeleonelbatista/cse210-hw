using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Unity Tutorial", "Philip Baker", 600);
        video1.AddComment(new Comment("Anna", "Very good!"));
        video1.AddComment(new Comment("Charles", "Really liked it."));
        video1.AddComment(new Comment("Betty", "Helped me a lot!"));
        videos.Add(video1);

        Video video2 = new Video("C# for Beginners", "Luke Smith", 450);
        video2.AddComment(new Comment("Mary", "Great explanation."));
        video2.AddComment(new Comment("John", "Thanks teacher!"));
        video2.AddComment(new Comment("Paul", "Awesome."));
        videos.Add(video2);

        Video video3 = new Video("Python Machine Learning", "Julia Costa", 800);
        video3.AddComment(new Comment("Robert", "Amazing!"));
        video3.AddComment(new Comment("Larissa", "Want more videos like this."));
        video3.AddComment(new Comment("Gabriel", "Learned a lot."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}
