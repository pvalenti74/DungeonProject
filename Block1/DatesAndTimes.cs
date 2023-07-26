namespace Block1
{
    internal class DatesAndTimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dates and Times");
            Console.Title = "Dates and Times";

            #region Source Control Notes:
            /*
             * Creating a repository using the VS interface.
             * In the bottom right of your VS window, click "Add to source control." > Git
             * Connect your GitHub account, if it's not already.
             * Check the privacy. Private for class, public for portfolio pieces.
             * .gitignore should say VisualStudio or Default (VisualStudio)
             * 
             * * Daily Steps:
             * 1. Pull on main to make sure you have the most up-to-date code.
             * 2. Create a new branch for whatever your doing that day. lower-case-with-hyphens
             * 3. Code.
             * 4. Commit/commit and push
             * 5. Create a pull request (on GitHub) when you're done with the branch.
             * 6. (Pretend you're the boss) merge the pull request (on GitHub)
             * 7. (in Visual Studio/VS Code) switch back to main and Pull.
             */
            #endregion

            #region DateTime Notes
            /*
             * DateTime is a class from the framework
             * that we can use as a datatype to create variables that 
             * hold date and time information.
             * 
             * Time defaults to 12am
             * 
             * This is a complex data type, unlike bools, ints, etc
             * which are all intrinsic data types
             * 
             * Complex data types often need the NEW keyword and
             * constructor method, which has the same name as the
             * data type.
             *
             * One example we've already done:
             * string[] colors = new string[5];
             * 
             * Syntax for DateTime:  
             * DateTime x = new DateTime();
             * 
             * You can use format specifiers on DateTime. 
             * (d, D, M, t, T, f, F)
             * */
            #endregion

            //Dec 14
            DateTime gradDate = new DateTime(2023, 12, 14, 16, 30, 01);
            Console.WriteLine($"Graduation Date: {gradDate}");//short date + long time
            Console.WriteLine($"Graduation Date: {gradDate:M}");//Month Day
            Console.WriteLine($"Graduation Date: {gradDate:D}");//Long Date (no time)

            DateTime weekAfterGrad = gradDate.AddDays(7);
            Console.WriteLine($"A week after graduation: {weekAfterGrad:D}");
            Console.WriteLine($"A week before graduation: {gradDate.AddDays(-7):D}");//in order to subtract days, add negative days.
            //Time stamp - current system date and time.
            //In C#, we can get the date only with midnight as the time using DateTime.Today.
            //To get both the date and the time, we can use DateTime.Now

            Console.WriteLine($"The current date and time, dynamically generated: {DateTime.Now:F}");
            Console.WriteLine($"The current date only: {DateTime.Today:F}");

            Console.WriteLine($"The days until graduation: {(gradDate.Subtract(DateTime.Now)):dd\\ hh\\:mm\\:ss}\n");
                                                            //gradDate - DateTime.Now
            //TimeSpan is a complex datatype that we get when we subtract two dates.
            //It records all of the units of measurement for time up until days.
            
            #region Terminator
            Console.WriteLine("\n\nThe program has finished. Press any key to exit...");
            Console.ReadKey();
            #endregion
        }//end Main()
    }//end class
}//end namespace