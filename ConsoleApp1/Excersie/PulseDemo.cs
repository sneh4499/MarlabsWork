//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ConsoleApp.Excersie
//{
//    internal class PulseDemo
//    {
//        const int numberLimit = 50;
//        private static readonly object lockMonitor = new object();
//        static void Main()
//        {
//            Thread EvenThread = new Thread(PrintEvenNumbers);
//            Thread OddThread = new Thread(PrintOddNumbers);

//            EvenThread.Start();
//            Thread.Sleep(100);
//            OddThread.Start();

//            EvenThread.Join();
//            OddThread.Join();

//            Console.WriteLine("Main Thread Ended");
//            Console.ReadKey();

//        }

//        static void PrintEvenNumbers()
//        {
//            try
//            {
//                Monitor.Enter(lockMonitor);
//                for (int i = 0; i <= numberLimit; i = i + 2)
//                {
//                    Console.Write($"{i}  ");
//                    //Notify Odd Number Thread that I am done, you print the odd number
//                    //Notify the thread in the waiting queueof the change in locked resource
//                    Monitor.Pulse(lockMonitor);
//                    //Calling pulse means that I will wait here till Odd thred notify me 
//                    //Monitor.Wait(lockMonitor)
//                    bool isLats = false;
//                    if (i == numberLimit)
//                    {
//                        isLats = true;
//                    }
//                    if (!isLats)
//                    {
//                        Monitor.Wait(lockMonitor);
//                    }
//                }

//            }
//            finally { Monitor.Exit(lockMonitor); }
//        }

//        private static void PrintOddNumbers()
//        {
//            try
//            {
//                Monitor.Enter(lockMonitor);
//                for (int i = 1; i <= numberLimit; i = i + 2)
//                {
//                    Console.Write($"{i}  ");
//                    Monitor.Pulse(lockMonitor);
//                    bool isLats = false;

//                    if (i == numberLimit - 1)
//                    {
//                        isLats = true;
//                    }
//                    if (!isLats)
//                    {
//                        Monitor.Wait(lockMonitor);
//                    }

//                }
//            }
//            finally
//            {
//                Monitor.Exit(lockMonitor);
//            }
//        }
//    }
//}
