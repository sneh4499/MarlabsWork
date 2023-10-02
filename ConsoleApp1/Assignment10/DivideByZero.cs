using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class DivideByZero
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("This is DividebyZero Example: Please Provide two numbers for divison");

        //        Console.Write("Enter the numerator: ");
        //        int numerator = ConvertToInt(Console.ReadLine());

        //        Console.Write("Enter the denomitor: ");
        //        int denomitor = ConvertToInt(Console.ReadLine());

        //        Console.WriteLine("The answer of " + numerator + "/" + denomitor + " is: " + Divide(numerator, denomitor));
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("An error occured: This is DevideByZeroException. Division by zero is not allowed.");
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("An error occured: Invalid input. Please enter valid integers.");
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
        static int Divide(int numerator, int denomitor)
        {
            return numerator / denomitor;
        }
    }
}
