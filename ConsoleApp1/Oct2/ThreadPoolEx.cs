using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1.Oct2
{
    internal class ThreadPoolEx
    {
        static void Main()
        {
            // Queue some tasks to the thread pool
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(Process, i);
            }

            Thread.Sleep(1000);

            Console.WriteLine("All tasks have been completed.");
        }

        static void Process(object state)
        {
            Thread th = Thread.CurrentThread;
            int taskId = (int)state;
            Console.WriteLine($"Background Thread : {th.IsBackground}, Task {taskId} is running on Thread {th.ManagedThreadId}");
        }
    }
}
