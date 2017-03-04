using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var motoPlant = new MotoPlant();
            var autoPlant = new AutoPlant();

            var engineer = new Engineer(motoPlant);
            Console.WriteLine($"Engineer create {engineer.Construct()}");

            engineer = new Engineer(autoPlant);
            Console.WriteLine($"Engineer create {engineer.Construct()}");

            Console.ReadLine();
        }
    }
}
