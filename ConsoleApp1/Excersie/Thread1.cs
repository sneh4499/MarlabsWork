//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApp.Excersie
//{
//    internal class Thread1
//    {
//        public int Count;
//        public string Name;

//        public Thread thread;

//        public Thread1(string name, int num)
//        {
//            Count = 0;
//            thread = new Thread(this.Run);
//            thread.Name = name;
//            thread.Start(num);
//        }

//        void Run(object num)
//        {
//            Console.WriteLine(thread.Name + " starting...");
//            do
//            {
//                Thread.Sleep(500);
//                Console.WriteLine("In " + thread.Name + ", count " + Count+ " Passed: " + num);
//                Count++;
//            } while (Count < 10);
//        }
//    }

//    class MutliThread
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Main thread starting..");

//            Thread1 mt = new Thread1("Child 1", 5);
//            Thread1 mt2 = new Thread1("Child 2", 4);

//            mt.thread.Priority = ThreadPriority.Highest;

//            mt.thread.Join();

//            Console.WriteLine("Main thread ending..");
//            Console.ReadKey();
//        }
//    }
//}
