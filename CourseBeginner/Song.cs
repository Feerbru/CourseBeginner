using System;
namespace CourseBeginner
{
    public class Song : IMedia
    {
        public long Seconds { get; set; }

        public string Title { get; set; }

        public ShelvePosition Position { get; set; }


        public void Play()
        {
            Console.WriteLine($"Playing {Title}");
        }
    }
}
