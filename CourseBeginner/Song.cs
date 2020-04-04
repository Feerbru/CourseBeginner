using System;
namespace CourseBeginner
{
    public class Song : Media
    {
        public long Seconds { get; set; }

        public ShelvePosition Position { get; set; }

        public override void Play()
        {
            Console.WriteLine("Increase volumen");
            base.Play();
        }

    }

}
