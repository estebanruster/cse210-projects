/*
Author: Esteban Rubén Mangas Calva
W04 Assignment: YouTube Video Program
Abstraction principle
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        //Video #1 and its comments
        Video video1 = new Video();
        video1._title = "Mario Kart World release!";
        video1._author = "MKFan";
        video1._lengthS = "720";
        for (int i = 0; i < 3; i++)
        {
            Comment comment = new Comment();
            comment._name = $"MKenjoyer{i + 4}";
            comment._text = $"I'm ready to race in {i + 1} hour";
            video1._comments.Add(comment);
        }

        //Video #2 and its comments
        Video video2 = new Video();
        video2._title = "The new Mario Kart game is here!";
        video2._author = "longcat MKracer";
        video2._lengthS = "1200";
        for (int i = 0; i < 4; i++)
        {
            Comment comment = new Comment();
            comment._name = $"looongcat fan{i * 4}";
            comment._text = $"I love so much Mario Kart. I love it {i + 1},000!";
            video2._comments.Add(comment);
        }

        //Video #3 and its comments
        Video video3 = new Video();
        video3._title = "Switch 2; testing new console.";
        video3._author = "PatoWeb";
        video3._lengthS = "480";
        Comment comment1 = new Comment();
        comment1._name = "Esteban Mangas";
        comment1._text = "The new Mario Kart game looks good in the console.";
        video3._comments.Add(comment1);
        Comment comment2 = new Comment();
        comment2._name = "PatoWeb fan";
        comment2._text = "The console testing looks good. Thanks for the video.";
        video3._comments.Add(comment2);
        Comment comment3 = new Comment();
        comment3._name = "Sara Sarixa16";
        comment3._text = "My little brother wants that console and the Kart game.";
        video3._comments.Add(comment3);

        //List of videos
        List<Video> videos = [video1, video2, video3];

        //Program iterates through the videos list and display the video info and its comments
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
        /*
        Test display videos
        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();
        */
    }
}