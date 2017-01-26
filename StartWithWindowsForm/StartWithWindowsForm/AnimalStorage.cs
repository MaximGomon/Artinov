using System.Collections.Generic;

namespace StartWithWindowsForm
{
    public static class AnimalStorage
    {
        static AnimalStorage()
        {
            Animals = new List<Animal>();
        }
        public static List<Animal> Animals { get; set; } 
    }
}