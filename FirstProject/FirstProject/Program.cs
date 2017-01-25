using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    sealed class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            int i = 2;
            bool isTrue = false;
            double d = 1.8;

            string str = "Hi";

            char ch = 'c';

            DateTime dt = new DateTime();
            dt = DateTime.Now;

            //str = "Hello";

            Console.WriteLine(str);
            Console.WriteLine(d);
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToString("dd - yyyy - MMMM hh:mm h-m z"));
            Console.WriteLine($"{i}");

            //0+1=1
            //1+1=10
            //1+1+1=11
            //7 == 111

            //var keyInfo = Console.ReadKey();
            Console.Clear();

            //while (true)
            //{
            //    ConsoleKeyInfo keyInfo = Console.ReadKey();
            //    Console.Clear();
            //    Console.WriteLine(keyInfo.Key);

            //    if (keyInfo.Key == ConsoleKey.Escape && i == 2)
            //    {
            //        break;
            //    }
            //}

            //for (int j = 0; j < 10; j = j - 1000000)
            //{
            //    Console.WriteLine(j);
            //    j = j - 10000;
            //}
            MyIntFunc();
            Console.WriteLine("The end");

            Console.ReadKey();
        }

        public void MyFunk()
        {
            
        }

        public static int MyIntFunc()
        {
            return MyIntFunc();
        }
    }
}
