using System;
using UniversalMediaPlayer;

AudioPlayer player = new AudioPlayer();

Console.WriteLine("================================");
Console.WriteLine(" UNIVERSAL MEDIA PLAYER");
Console.WriteLine("================================");

bool exit = false;

while (!exit)
{
    Console.WriteLine("\nSelect Media Type:");
    Console.WriteLine("1. MP3");
    Console.WriteLine("2. MP4");
    Console.WriteLine("3. VLC");
    Console.WriteLine("4. Exit");

    Console.Write("\nEnter Choice: ");
    string choice = Console.ReadLine() ?? string.Empty;

    switch (choice)
    {
        case "1":
            player.Play("mp3", "ShapeOfYou.mp3");
            break;

        case "2":
            player.Play("mp4", "AvengersTrailer.mp4");
            break;

        case "3":
            player.Play("vlc", "TutorialVideo.vlc");
            break;

        case "4":
            exit = true;
            Console.WriteLine("Exiting Media Player...");
            break;

        default:
            Console.WriteLine("Invalid Choice!");
            break;
    }
}
