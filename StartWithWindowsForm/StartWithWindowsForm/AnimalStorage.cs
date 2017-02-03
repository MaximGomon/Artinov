using System.Collections.Generic;
using System.Linq;

namespace StartWithWindowsForm
{
    public static class AnimalStorage
    {
        private static readonly AnimalsDbContext _context;
        static AnimalStorage()
        {
            _context = new AnimalsDbContext();
            Animals = _context.Animals;
        }
        public static IQueryable<Animal> Animals { get; set; } 
    }
}