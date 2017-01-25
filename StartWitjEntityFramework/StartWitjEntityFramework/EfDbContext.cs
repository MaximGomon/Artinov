using System.Data.Entity;

namespace StartWithEntityFramework
{
    public class EfDbContext : DbContext
    {
        public EfDbContext() : base("DbConnection")
        {
            Database.SetInitializer(new DictionaryInitializer());
            this.Database.Initialize(true);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>().HasOptional(x => x.Profession);
        }

        public DbSet<People> Peoples { get; set; }
        public DbSet<Profession> Professions { get; set; }

    }
}