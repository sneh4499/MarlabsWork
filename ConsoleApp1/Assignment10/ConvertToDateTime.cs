using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ConvertToDateTime
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("This is Convert to Date example:");
        //        Console.Write("Please enter date and time in the format of 'dd/mm/yyyy' : ");
        //        string input = Console.ReadLine();

        //        DateTime date = ConvertToDate(input);

        //        Console.WriteLine("Date: " + date.ToShortDateString());
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("An error occurred: Invalid date format. Please enter a valid date in the format of dd/mm/yyyy.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An error occurred: " + ex.Message);
        //    }
        //    Console.ReadKey();
        //}

        static DateTime ConvertToDate(string input)
        {
            string format = "dd/MM/yyyy";
            return DateTime.ParseExact(input, format, null);
        }
    }
}
