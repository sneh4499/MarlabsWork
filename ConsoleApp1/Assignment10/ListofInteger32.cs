using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ListofInteger32
    {
        //static void Main()
        //{
        //    List<int> numbers = new List<int>();

        //    try
        //    {
        //        Console.WriteLine("This is a List of Integers example:");
        //        Console.WriteLine("Please enter a list of integers (Please type 'exit' to finish):");

        //        while (true)
        //        {
        //            Console.Write("Input an integer: ");
        //            string input = Console.ReadLine();

        //            if (input.ToLower() == "exit")
        //            {
        //                break;
        //            }

        //            int number = ConvertToInt32(input);
        //            numbers.Add(number);
        //        }

        //        Console.WriteLine("Numbers entered:");
        //        foreach (int number in numbers)
        //        {
        //            Console.WriteLine(number);
        //        }
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("An error occured - Invalid input. Please enter a valid integer.");
        //    }
        //    catch (OverflowException)
        //    {
        //        Console.WriteLine("An error occured - The value entered is outside the range of Int32.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An error occurred - " + ex.Message);
        //    }

        //    Console.ReadKey();
        //}

        static int ConvertToInt32(string input)
        {
            return int.Parse(input);
        }
    }
}
