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
        
        public override bool Equals(Object obj){
            return base.Equals(obj);
        }

        public override int GetHashCode(){
            return base.GetHashCode();
        }

        public override string ToString(){
            return $"Title {Title} Duration {Seconds}";
        }


    }

}
