using System;

namespace StartWithWindowsForm
{
    public class Animal
    {
        public Animal()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; protected set; }
        public AnimalSize Size { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} {Size}";
        }
    }
}