using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUserKey
{
    class Program
    {
        static void Main(string[] args)
        {
            //break;
            //continue;
            //Console.Write("Please press some key: ");
            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //ConsoleKey pressetKey = keyInfo.Key;
            //Console.WriteLine("You pressed {0} key", pressetKey);

            while (true)
            {
                Console.WriteLine("If you want to exit - press \'Esc\' key.");
                Console.WriteLine("If you want to continue - press \'Space\' key.");
                ConsoleKey pressetKey = Console.ReadKey().Key;
                Console.WriteLine();
                if (pressetKey == ConsoleKey.Escape)
                {
                    break;
                }
                else if (pressetKey == ConsoleKey.Spacebar)
                {
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You pressed another key and program will continue working");
                }
            }
            Console.WriteLine("Program will be close after press any key...");
            Console.ReadLine();
        }
    }
}
