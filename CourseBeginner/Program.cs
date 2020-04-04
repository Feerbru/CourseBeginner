using System;

namespace CourseBeginner
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Song song = new Song();

            song.Title = "Dark side of moon";
            song.Seconds = 500;
            song.Position = new ShelvePosition(0, 0);
            song.Play();

            Console.ReadKey();
        }
    }
}
