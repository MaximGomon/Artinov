using System.Data.Entity;

namespace StartWithWindowsForm
{
    public class DbDictionaryInitializer : CreateDatabaseIfNotExists<AnimalsDbContext>
    {
        protected override void Seed(AnimalsDbContext context)
        {
            AnimalType birds = new AnimalType {Name = "Birds"};
            AnimalType fish = new AnimalType {Name = "Fish"};
            AnimalType seafish = new AnimalType {Name = "Sea fish", Parent = fish};
            AnimalType lakefish = new AnimalType {Name = "Lake fish", Parent = fish};
            AnimalType shark = new AnimalType {Name = "Shark", Parent = seafish};
            AnimalType corop = new AnimalType {Name = "Corop", Parent = lakefish};
            AnimalType solovei = new AnimalType {Name = "Solovei", Parent = birds};

            context.AnimalTypes.Add(birds);
            context.AnimalTypes.Add(fish);
            context.AnimalTypes.Add(solovei);
            context.AnimalTypes.Add(seafish);
            context.AnimalTypes.Add(lakefish);
            context.AnimalTypes.Add(corop);
            context.AnimalTypes.Add(shark);

            base.Seed(context);
        }
    }
}