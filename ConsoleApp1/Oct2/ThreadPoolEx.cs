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
                ThreadPool.QueueUserWorkItem(DoWork, i);
            }

            // Wait for the tasks to complete (just for demonstration purposes)
            Thread.Sleep(1000);

            Console.WriteLine("All tasks have completed.");
        }

        static void DoWork(object state)
        {
            int taskId = (int)state;
            Console.WriteLine($"Task {taskId} is running on Thread {Thread.CurrentThread.ManagedThreadId}");
            // Perform some work here
        }
    }
}
