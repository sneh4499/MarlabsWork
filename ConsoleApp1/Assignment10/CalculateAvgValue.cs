using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class CalculateAvgValue
    {
        // Calculate average method declare here..
        static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new EmptyArrayException("Array is empty. Cannot calculate average.");
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return (double)sum / numbers.Length;
        }
        //static void Main()
        //{
        //    try
        //    {
        //        Console.WriteLine("This is a Avrage value calculation example:");
        //        // getting input from user..
        //        Console.Write("Please Enter the size of an array: ");
        //        int count = Convert.ToInt32(Console.ReadLine());

        //        int[] ArrayofNums = new int[count];

        //        for (int i = 0; i < count; i++)
        //        {
        //            Console.Write("Enter Value " + (i + 1) + ": ");
        //            ArrayofNums[i] = Convert.ToInt32(Console.ReadLine());
        //        }

        //        double avrage = CalculateAverage(ArrayofNums);
        //        Console.WriteLine("Average value of given numbers is: " + avrage);
        //    }
        //    catch (EmptyArrayException ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Error: Invalid input. Please input integers only.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An error occurred: " + ex.Message);
        //    }
        //    Console.ReadKey();
        //}
    }
}

class EmptyArrayException : Exception
{
    public EmptyArrayException(string message) : base(message) { }
}
