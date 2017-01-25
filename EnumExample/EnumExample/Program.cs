using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sex.Man);
            //Console.WriteLine(Sex.Man.ToString("D"));
            Console.WriteLine(Sex.Woman);
            Console.WriteLine(Sex.Unknown);

            //Console.WriteLine(Sex.Woman.ToString("D"));
            string userInput = Console.ReadLine();

            Sex userChoise = (Sex) Enum.Parse(typeof (Sex), userInput);

            switch (userChoise)
            {
                case Sex.Woman:
                    Console.WriteLine($"This is {userChoise}");
                    break;
                case Sex.Man:
                    Console.WriteLine($"This is {userChoise}");
                    break;
                default:
                    Console.WriteLine("This is default");
                    break;
            }

            Console.ReadLine();
        }
    }

    public enum Sex
    {
        Man = 1,
        Woman,
        Unknown
    }
}
