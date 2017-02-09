using System.Data.Entity;

namespace StartWithWindowsForm
{
    public class AnimalsDbContext : DbContext
    {
        public AnimalsDbContext() : base("dbConnection")
        {
            
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }

    }
}