using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Oct2
{
    internal class BackgroundThreadsEx
    {
        static void BackgroundWork()
        {
            for(int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("This is Background thread running....");
            }
        }

        static void ForegroundWork()
        {
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("This is Foreground thread running....");
            }
        }

        static void Main()
        {
            Thread th1 = new Thread(BackgroundWork);
            th1.IsBackground = true;
            th1.Start();

            Thread th2 = new Thread(ForegroundWork);
            th2.Start();

            for(int i = 0;i < 2;i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("This is main thread running on...");
            }
        }
    }
}
