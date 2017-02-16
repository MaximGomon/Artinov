using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StartWithThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Start work");
            //CreateSimpleThread();
            //CreateThreadsUsingPool();
            //RunActions();
            //RunFunc();

            //Task<int> randomIntTask = new Task<int>(GetRandomInt);
            //randomIntTask.Start();

            //Console.WriteLine(randomIntTask.Result);

            CancellationTokenSource cts = new CancellationTokenSource();
            Task<int> funcTask = new Task<int>(GetRandomInt, cts.Token);
            
            Task funcTask2 = Task.Run(() => SumAndDisplay(4, 6));

            try
            {
                funcTask.Start();
                if (funcTask.Wait(1000))
                {
                    Console.WriteLine($"Task result: {funcTask.Result}");
                }
                else
                {
                    //cts.Cancel();
                    Console.WriteLine("Task was canceled! It`s message we newer see!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Task was canceled and rise error {ex.Message}");
            }
            
            Task.WaitAll(funcTask, funcTask2);
            Console.WriteLine($"Task status: {funcTask.Status}");
            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();
        }

        private static void RunFunc()
        {
            Func<int, int, double> sumFunk = Divide;
            Console.WriteLine($"Result: {sumFunk.Invoke(5, 2)}");

            Func<int> randomFunc = GetRandomInt;
            Console.WriteLine($"Random int: {randomFunc.Invoke()}");
        }

        private static int GetRandomInt()
        {
            Random r = new Random();
            Thread.Sleep(3000);
            return r.Next(3000);
        }

        private static double Divide(int a, int b)
        {
            return (double)a / b;
        }

        private static void RunActions()
        {
            Action<object> a = DisplayNumber;
            a.Invoke(44);

            Action<int, int> sumAction = SumAndDisplay;
            sumAction.Invoke(4, 7);
        }

        private static void SumAndDisplay(int a, int b)
        {
            Thread.Sleep(500);
            Console.WriteLine($"Result is: {a + b}");
        }

        private static void CreateThreadsUsingPool()
        {
            ThreadPool.UnsafeQueueUserWorkItem(DisplayNumber, 44);
            ThreadPool.UnsafeQueueUserWorkItem(DisplayNumber, 12);
            ThreadPool.UnsafeQueueUserWorkItem(DisplayNumber, 37);
            ThreadPool.UnsafeQueueUserWorkItem(DisplayNumber, 5);
        }

        private static void CreateSimpleThread()
        {
            Thread th = new Thread(DisplayNumber);
            th.IsBackground = true;
            th.Start(5);

            Console.WriteLine("Start new thread");
            Console.WriteLine("Main thread do something there...");
            Thread.Sleep(1000);

            th.Join();
        }

        public static void DisplayNumber(object number)
        {
            //Thread.Sleep(5000);
            Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Input number is {number}!");
            Console.WriteLine("End display number");
        }
    }
}
