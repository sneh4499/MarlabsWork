using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ConvertStringToInteger
    {
        //static void Main()
        //{
        //    try
        //    {
        //        Console.WriteLine("This is Convert to String example:");
        //        Console.Write("Please enter a number: ");
        //        string input = Console.ReadLine();

        //        int number = ConvertToInt(input);

        //        Console.WriteLine("Number: " + number);
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error: Invalid input. Please enter a valid integer value.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An error occurred: " + ex.Message);
        //    }
        //    Console.ReadKey();
        //}

        static int ConvertToInt(string input)
        {
            return int.Parse(input);
        }
    }
}
