using System;

namespace Builder
{
    public class MotoPlant : IPlant
    {
        public Product Construct()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("Create body");
            Console.WriteLine("Create whells");
            Console.WriteLine("Create engine");
            Console.WriteLine("Combine body and engine");
            Console.WriteLine("Combine all created parts");
            return new Product
            {
                Name = "Moto"
            };
        }
    }
}