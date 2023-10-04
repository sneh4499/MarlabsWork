using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1.Excersie
{
    internal class ThreadStateEx
    {
        [Obsolete]
        static void Main()
        {
            Thread th = new Thread(Work);
            Console.WriteLine($"Thread is Alive: {th.IsAlive}, Thread State: {th.ThreadState}");
            th.Start();
            Console.WriteLine($"Thread is Alive: {th.IsAlive}, Thread State: {th.ThreadState}");

            Thread.Sleep(1000);
            Console.WriteLine($"Thread is Alive: {th.IsAlive}, Thread State: {th.ThreadState}");

            th.Join();
            Console.WriteLine($"Thread is Alive: {th.IsAlive}, Thread State: {th.ThreadState}");

            th.Abort();
            Console.WriteLine($"Thread is Alive: {th.IsAlive}, Thread State: {th.ThreadState}");

            Console.ReadKey();
        }

        static void Work()
        {
            for(int i = 0; i < 5; i++)
            {
                //Console.WriteLine($"Running ...{i}");
                Thread.Sleep(1000);
            }
        }
    }
}
