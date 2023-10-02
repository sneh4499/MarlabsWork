using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Excersie
{
    internal class OpenExistMutex
    {
        static Mutex mutex = null;
        static void Main()
        {
            //IsSingleInstance returns true to continue with program else Exit the Program
            if (!IsSingleInstance())
            {
                Console.WriteLine("More then one instance");
            }
            else
            {
                Console.WriteLine("One Instance");
            }
            Console.ReadLine();
        }
        static bool IsSingleInstance()
        {
            try
            {
                //try to open an Existing Mutex 
                //If the Mutex is not opened, then it will throw an exception
                var result = Mutex.OpenExisting("MyMutex");
                Console.WriteLine("Result");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                mutex = new Mutex(true, "MyMutex");
                return true;
            }
            //More than one instance 
            return false;
        }
    }
}
