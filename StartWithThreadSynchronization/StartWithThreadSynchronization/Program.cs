using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StartWithThreadSynchronization
{
    class Program
    {
        private static object _synchObject = new object();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Start program!");
            Console.WriteLine(new string('-', 50));

            Console.ForegroundColor = ConsoleColor.Yellow;
            ThreadStartClass startPoint = new ThreadStartClass();
            Thread[] threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(startPoint.Start);
            }
            Count = 11;
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    threads[i].Start();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Never catch exception!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

            }
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(new string('-', 50));
            //Console.WriteLine("End program!");
            Console.ReadKey();
        }

        private static int Count { get; set; }

        static void ThreadStartFunction()
        {
            //Trhead synchronize construction
            lock (_synchObject)
            {
                if (SimulateException()) return;
                //Display current thread number
                Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} start execute.");
                //simly counting to 10
                for (int i = 0; i < 5; i++)
                {
                    //logic to display number at one row
                    if (i < 4)
                        Console.Write(i + ", ");
                    else
                        Console.WriteLine(i);
                    //Create new random for generating random numbers
                    Random r = new Random();
                    //Sleep current thread random count of milliseconds
                    Thread.Sleep(300 * r.Next(5));
                }
                Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} end execute.");
            }
        }

        private static bool SimulateException()
        {
            if (Thread.CurrentThread.ManagedThreadId == Count)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ends with error.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                return true;
            }
            return false;
        }

        static void ThreadStartMonitorFunction()
        {
            //Trhead synchronize construction
            Monitor.Enter(_synchObject);
            try
            {
                if (SimulateException()) return;
                //Display current thread number
                Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} start execute.");
                //simly counting to 10
                for (int i = 0; i < 10; i++)
                {
                    //logic to display number at one row
                    if (i < 9)
                        Console.Write(i + ", ");
                    else
                        Console.WriteLine(i);
                    //Create new random for generating random numbers
                    Random r = new Random();
                    //Sleep current thread random count of milliseconds
                    Thread.Sleep(500 * r.Next(5));
                }
                Console.WriteLine($"Thread #{Thread.CurrentThread.ManagedThreadId} end execute.");

            }
            finally 
            {
               Monitor.Exit(_synchObject);
            }
        }
    }
}
