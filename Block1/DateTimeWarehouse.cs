using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class DateTimeWarehouse
    {
        //No static void Main()
        //This is intended to be a helper file that is not meant to be run on its own. 

        //it will contain methods used for datetime functions.
        internal static void DisplayTime()
        {
            Console.WriteLine(DateTime.Now.ToString("T"));
        }//end displaytime()

        internal static void DisplayTime(DateTime dateToDisplay)
        {
            //every method must have a unique name and parameter combination. Only the datatype of the parameters matters.
            Console.WriteLine($"{dateToDisplay:dddd\\, MMM\\ dd\\, yyyy\\ hh\\:mm\\ tt}");
        }//end DisplayTime overload

        //internal static void DisplayTime(DateTime helloOperator)
        //{
        // the DATATYPE must be different
        //}

        internal static DateTime CalculateDate(int days)
        {
            DateTime newDate = DateTime.Now.AddDays(days);
            //after you have created an object with the same datatype as the "return type" in the method
            //signature, you must "return" it to the program that called this method.
            return newDate;
        }//end CalculateDate

        internal static void CalendarApp()
        {
            Console.Write("Please enter a number of days from today to display: ");
            int.TryParse(Console.ReadLine(), out int days);            
            DateTime newDate = CalculateDate(days);
            DisplayTime(newDate);
        }//end CalendarApp()

    }//end class
}//end namespace
