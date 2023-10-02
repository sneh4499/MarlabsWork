using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Excersie
{
    internal class SemaphoreEx
    {
            static SemaphoreSlim gate = new SemaphoreSlim(2, 5);
            static void Main(string[] args)
            {
                SemaphoreEx ob = new SemaphoreEx();
                ob.task();
                Thread.Sleep(1000);
                gate.Release(1);
                Console.ReadLine();
                gate.Release(5);

            }
            async public void task()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Start");
                    await gate.WaitAsync();
                    Console.WriteLine($": Do some Work");
                }
            }
    }
}
