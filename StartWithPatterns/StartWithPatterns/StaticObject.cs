namespace Singleton
{
    public class StaticObject
    {
        public static int ObjectId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{ObjectId} {Name}";
        }
    }
}