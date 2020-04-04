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
            //song.Play();

            Song song2 = new Song();
            song2.Title = "Dark side of moon";
            song2.Seconds = 300;
            song2.Position = new ShelvePosition(1,0);

            Console.WriteLine(song2.ToString());

            Console.ReadKey();
        }
    }
}
