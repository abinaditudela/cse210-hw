using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create 3-4 video objects
        Video video1 = new Video("The Secrets of the Universe", "John Doe", 300);
        Video video2 = new Video("How to Cook the Perfect Steak", "Jane Smith", 420);
        Video video3 = new Video("Learn Programming in 10 Minutes", "Mike Johnson", 600);

        // Add comments to the first video
        video1.AddComment(new Comment("Alice", "This video was amazing!"));
        video1.AddComment(new Comment("Bob", "I learned so much from this."));
        video1.AddComment(new Comment("Charlie", "Can you make more content like this?"));

        // Add comments to the second video
        video2.AddComment(new Comment("David", "I love this recipe, tried it yesterday!"));
        video2.AddComment(new Comment("Eve", "Wow, I never knew about these techniques."));
        video2.AddComment(new Comment("Frank", "My steak came out perfect, thank you!"));

        // Add comments to the third video
        video3.AddComment(new Comment("George", "This was so helpful, thank you!"));
        video3.AddComment(new Comment("Hannah", "Can you do a more advanced tutorial?"));
        video3.AddComment(new Comment("Ian", "Great tutorial, but it felt too fast."));

        // Store all videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list of videos and display the details for each one
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
