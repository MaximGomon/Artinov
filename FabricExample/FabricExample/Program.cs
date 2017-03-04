using System;
using FabricExample.Factories;

namespace FabricExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Console.WriteLine(new string('-', 40));
            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Console.WriteLine(new string('-', 40));
            var superVoin = new Hero(new SuperHeroFactory());
            superVoin.Hit();
            superVoin.Run();

            Console.ReadLine();
        }
    }
}
