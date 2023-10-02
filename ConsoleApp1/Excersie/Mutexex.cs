using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Excersie
{
    internal class Mutexex
    {
        private static Mutex _mutex = new Mutex();
        static void Main()
        {
            //CREATE MULTIPLE THREADS 
            for (int i = 1; i <= 5; i++)
            {
                Thread thrdObj = new Thread(MutexDemo)
                {
                    Name = "Thread: " + i
                };
                thrdObj.Start();
            }
            #region
            //using (Mutex mutex = new Mutex(false, "MutexDemo"))
            //{
            //    //Check if there is any other external thread is Running this section
            //    if (!mutex.WaitOne(5000, false))
            //    {
            //        Console.WriteLine("An instance of the Application is Already running");
            //        Console.ReadKey();
            //        return;
            //    }
            //    Console.WriteLine("Application is running");
            //    Console.ReadKey();
            //}
            #endregion
        }
        static void MutexDemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter the Critical " +
                "Section for processing");
            try
            {
                //Blocks the current untill the current WaitOne() receives a signal
                //Waits until its safer to enter
                _mutex.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");
                Thread.Sleep(2000);
                Console.WriteLine("Exit:" + Thread.CurrentThread.Name + " is Completed its task");
            }
            finally
            {
                //Once ReleaseMutex is called its unblocks the CS so that other threads 
                //that are trying to get ownership of the mutex can enter
                _mutex.ReleaseMutex();
            }
        }
    }
}
