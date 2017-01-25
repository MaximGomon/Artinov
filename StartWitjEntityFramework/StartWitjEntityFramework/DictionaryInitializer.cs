using System.Data.Entity;

namespace StartWithEntityFramework
{
    public class DictionaryInitializer : CreateDatabaseIfNotExists<EfDbContext>
    {
        protected override void Seed(EfDbContext context)
        {
            context.Professions.Add(new Profession { Name = "Admin" });
            context.Professions.Add(new Profession { Name = "User" });
            base.Seed(context);
        }
    }
}