using System;

namespace StartWithClasses
{
    public abstract class Animals
    {
        private string _name;//Field
        public AnimalType Type { get; set; }
        public string Name//Property
        {
            get { return _name; }
            private set { _name = value; }
        }

        public Animals(string name)//Constructor
        {
            Name = name;
        }

        public virtual void Say()//method
        {
            Console.WriteLine("I am animal");
        }
    }
}