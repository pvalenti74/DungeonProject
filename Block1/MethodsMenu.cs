using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignatureLibrary;

namespace Block1
{
    internal class MethodsMenu
    {
        //the public keyword allows us to use methods (including Main()) in other documents.
        public static void Main(string[] args)
        {
            //Console.WriteLine("Methods Menu - Creating our own methods!");
            Signatures.Header("Custom Methods");
            /*
             * This program lets the user choose between various
             * "mini-programs" to run. It is set up inside a loop
             * to repeat based on user choice.
             * 
             * All choices will call on a method where the real
             * functionality is located.
             * 
             * Developers put functionality into methods to be more
             * reusable or sometimes just to "tidy up" their code.
             * 
             * Note: Static methods defined inside this class will be
             * able to be called directly without using the class name. 
             * Methods OUTSIDE the class BUT INSIDE the project will
             * be called from ClassName.MethodName.
             */
            bool exit = false;//external sentinal variable (COUNTER)
            do
            {
                Console.WriteLine("\nPlease choose a program\n" +
                    "1. Break Change\n" +
                    "2. Water Weight\n" +
                    "3. Numbers\n" +
                    "4. Display Time\n" +
                    "5. Calendar App\n" +
                    "6. Exit\n\n");
                char choice = Console.ReadKey(true).KeyChar;
                Console.Clear();
                switch (choice)
                {

                    case '1':
                        Console.WriteLine("Break Change");
                        BreakChange();
                        break;

                    case '2':
                        Console.WriteLine("Water Weight");
                        WaterWeight();
                        break;

                    case '3':
                        Console.WriteLine("Numbers");
                        MethodsMenu.CountNumbers();
                        break;

                    case '4':
                        Console.WriteLine("Display Time");
                        DateTimeWarehouse.DisplayTime();
                        break;

                    case '5':
                        Console.WriteLine("Calendar App");
                        DateTimeWarehouse.CalendarApp();
                        break;

                    case '6':
                        Console.WriteLine("Thanks for playing!");
                        //exit = !exit;
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("That wasn't an option, goofy!");
                        break;
                }
            } while (!exit); //exit == false
        }//end Main()

        //additional methods could go here.
        private static void CountNumbers()
        {
            //private - only used within this class
            //void - all the work is done here, nothing to return
            //no parameters as we don't need any additional information.
            Console.Write("Enter a whole number to count to: ");
            int.TryParse(Console.ReadLine(), out int userNumber);

            for (int i = 1; i <= userNumber; i++)
            {
                Console.WriteLine(i);
            }//end for

        }//end CountNumbers()
        //MINILAB:
        //write two methods, one for BreakChange() and one for WaterWeight(). Call these methods in your menu.
        private static void BreakChange()
        {
            Console.Title = "===== BREAK CHANGE LAB =====";
            Console.Write("Please enter an amount of dollars and cents:");

            if (!decimal.TryParse(Console.ReadLine(), out decimal userDecimal))
            {
                Console.WriteLine("That wasn't a valid number. Come back sober.");
                return;
            };
            int pennies = (int)(userDecimal * 100);
            int quarters = pennies / 25; pennies %= 25;
            int dimes = pennies / 10; pennies %= 10;
            int nickels = pennies / 5; pennies %= 5;
            Console.WriteLine("\nYou have:\n{0} Quarters\n{1} Dimes\n{2} Nickels" +
                "\n{3} Pennies", quarters, dimes, nickels, pennies);
        }
        private static void WaterWeight()
        {
            Console.WriteLine("Lab - Water Weight");

            decimal galWaterInLbs = 8.33m;
            Console.Write("How many gallons of water? ");
            string? userGal = Console.ReadLine();
            decimal userGalNbr = Convert.ToDecimal(userGal);
            userGalNbr *= galWaterInLbs;
            Console.WriteLine($"That weighs {userGalNbr} pounds!");
        }
    }//end class
}//end namespace
