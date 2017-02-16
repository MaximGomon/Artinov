using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingAsyncAwait
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Start main thread");

            Task.Run(new Action(DisplayTaskId));

            Console.WriteLine("End of main thread");
            Console.ReadKey();
        }

        private static async void DisplayTaskId()
        {
            try
            {
                int? id = Task.CurrentId;
                Console.WriteLine($"This is Task# {id}");
                await Task.Run(() => SumAndDisplay(4, 9));
                Console.WriteLine($"This is end of Task# {id}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

        }
        private static void SumAndDisplay(int a, int b)
        {
            Console.WriteLine($"Sleep thread of Task# {Task.CurrentId}");
            Thread.Sleep(5000);
            //throw new InvalidOperationException("This is invalid operation");
            Console.WriteLine("Result is:{0}", a + b);
        }
    }
}
