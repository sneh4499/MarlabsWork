using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class CalculateFactorial
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("This is an example of Factorial Calculation with exceptions..");
        //        Console.Write("Please enter a positive number: ");
        //        int number = Convert.ToInt32(Console.ReadLine());

        //        if (number < 0)
        //        {
        //            throw new ArgumentException("Number must be positive.");
        //        }

        //        int factorial = Factorial(number);

        //        Console.WriteLine("Factorial of " + number + " is : " + factorial);
        //    }
        //    catch (OverflowException)
        //    {
        //        Console.WriteLine("An error occured: Factorial exceeds the maximum value of Int32.");
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("An error occured: Invalid input. Please enter a valid number.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An error occurred: " + ex.Message);
        //    }

        //    Console.ReadKey();
        //}

        static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                checked
                {
                    factorial *= i;
                }
            }

            return factorial;
        }
    }
}
