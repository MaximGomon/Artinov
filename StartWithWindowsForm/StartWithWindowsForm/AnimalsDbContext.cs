using System.Data.Entity;

namespace StartWithWindowsForm
{
    public class AnimalsDbContext : DbContext
    {
        public AnimalsDbContext() : base("dbConnection")
        {
            //Усданавливаем инициализатор базы данных
            Database.SetInitializer(new DbDictionaryInitializer());
            //принудительно вызываем инициализацыю базы данных
            this.Database.Initialize(true);
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }

    }
}