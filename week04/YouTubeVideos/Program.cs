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
        //Test display video#1
        video1.DisplayVideo();
    }
}