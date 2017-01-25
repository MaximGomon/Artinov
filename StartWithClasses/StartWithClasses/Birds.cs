using System;

namespace StartWithClasses
{
    public class Birds : Animals
    {
        public int Weight { get; set; }

        public Birds(string name) : base(name)
        {
        }
        public override void Say()//method
        {
            Console.WriteLine($"I am bird {Name}");
        }

        public override string ToString()
        {
            return $"{Name} {Weight} {Type}";
        }
    }
}