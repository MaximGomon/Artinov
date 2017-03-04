using System;

namespace Builder
{
    public class AutoPlant : IPlant
    {
        public Product Construct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Create engine");
            Console.WriteLine("Create whells");
            Console.WriteLine("Create body");
            Console.WriteLine("Combine all created parts");
            return new Product
            {
                Name = "Car"
            };
        }
    }
}