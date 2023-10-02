using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class CalculateSqrt
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("This is a Square root calculation example:");
        //    try
        //    {
        //        Console.Write("Enter a number for Square Root Calculation : ");
        //        double number = Convert.ToDouble(Console.ReadLine());

        //        if (number >= 0)
        //        {
        //            double squareRoot = FindSqrt(number);
        //            Console.WriteLine("A Square root of " + number + " is : " + squareRoot);
        //        }
        //        else
        //        {
        //            throw new ArgumentException("Number cannot be negative! Please enter a positive number.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An error occured : " + ex.Message);
        //    }
        //    Console.ReadKey();
        //}

        static double FindSqrt(double input)
        {
            return Math.Sqrt(input);
        }
    }
}
