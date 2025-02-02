using System;

class Program
{
    static void Main(string[] args)
    {
          List<Video> videos = new List<Video>();
        
        Video video1 = new Video("Learning C#", "Magloire Lugozi", 300);
        video1.AddComment("Amiel Matadi", "Great tutorial!");
        video1.AddComment("Franck", "Very helpful, thanks!");
        video1.AddComment("President Mukanya", "Nice explanation.");
        videos.Add(video1);
        
        Video video2 = new Video("Team Leading", "John Lwamba", 420);
        video2.AddComment("Henry", "I finally understand OOP!");
        video2.AddComment("Big Boss", "This was so clear.");
        videos.Add(video2);
        
        
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}