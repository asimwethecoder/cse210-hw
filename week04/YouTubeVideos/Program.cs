using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Morning Routine & Desk Setup 2026", "TechWithMaya", 645);
        video1.AddComment(new Comment("LiamCarter", "Love how clean that desk setup looks!"));
        video1.AddComment(new Comment("NadiaK", "What monitor arm are you using in the clip?"));
        video1.AddComment(new Comment("DevonR", "Great pacing and super relaxing morning vlog."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("5 Everyday Snacks You Didn't Know Were Sponsored", "BrandWatchDaily", 490);
        video2.AddComment(new Comment("SamiraH", "I had no idea that energy bar was featured so often."));
        video2.AddComment(new Comment("ChrisP", "Really interesting breakdown of product placement."));
        video2.AddComment(new Comment("TessaW", "Subscribed for more media analysis videos."));
        video2.AddComment(new Comment("JordanM", "The comparison chart at 4:10 was super helpful."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Weekend Road Trip Packing Guide", "TravelWithOwen", 820);
        video3.AddComment(new Comment("HannahB", "That travel backpack is a lifesaver on short trips."));
        video3.AddComment(new Comment("GabeL", "Adding a few of these items to my list before next weekend."));
        video3.AddComment(new Comment("ChloeT", "Clean shots and practical tips all around."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Home Espresso Bar Upgrade Tour", "BrewCraftStudio", 575);
        video4.AddComment(new Comment("MarcusV", "That grinder looks rock solid."));
        video4.AddComment(new Comment("PriyaS", "Been eyeing that espresso machine for months!"));
        video4.AddComment(new Comment("ElenaG", "Great audio and crisp video quality."));
        videos.Add(video4);

        // Display each video and its comments
        foreach (Video video in videos)
        {
            video.DisplayDetails();
            Console.WriteLine(new string('-', 50));
        }
    }
}
