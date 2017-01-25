using System;

namespace StartWithClasses
{
    public class Mammal : Animals
    {
        public int Heigth { get; set; }
        public Mammal(string name) : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("I am mammal");
        }
    }
}