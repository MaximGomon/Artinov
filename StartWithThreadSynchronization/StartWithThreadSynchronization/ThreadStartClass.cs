using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace StartWithThreadSynchronization
{
    [Synchronization]
    public class ThreadStartClass : ContextBoundObject
    {
        public void Start()
        {
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
}