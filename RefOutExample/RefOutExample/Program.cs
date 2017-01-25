using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            Increase(ref number);
            Console.WriteLine(number);
            Increase(ref number);
            Console.WriteLine(number);

            int c;
            int b = NumberReturn(out c);
            Console.WriteLine($"{b} {c}");

            Console.ReadLine();
        }

        private static void Increase(ref int i)
        {
            i++;
        }

        public static int NumberReturn(out int i)
        {
            i = 0;
            int a = i;
            return ++a;
        }
    }
}
