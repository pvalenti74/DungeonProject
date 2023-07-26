namespace Block1
{
    internal class RandomPractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice with the Random Class");
            Console.Title = "Random Practice";

            #region Random Notes
            /*
             * Random is a class in the framework. It has
             * an instance method Next(), which generates the "next" random 
             * number in a desired range, if a range is specified.
             * 
             * As an "instance" method, you must have instantiated 
             * (initialized) a Random object (variable of type Random)
             * to call it.
             * Examples:
             * ToUpper(), ToLower(), AddDays(), ToString()
             * 
             * The alternative to instance is static, which requires you
             * to call the ClassName where it was defined to access it:
             * Examples: 
             * int.Parse(), Array.Sort(), Console.WriteLine()
             */
            #endregion
            Random rand = new Random();
            //Created a new Random object (object of type Random)
            //The NEW keyword is REQUIRED! The Constructor name (Random()) is optional. It could just be new();

            int randomNumber = rand.Next();
            Console.WriteLine($"{randomNumber:n0}");

            //The Next() is "overloaded" to accept 3 different parameter sets.
            //1) No parameters - Returns an int from 0 to int.MaxValue
            //2) 1 parameter - int for MaxValue (exclusive upper bound, defaults min to 0)
            //3) 2 params - int for MinValue (inclusive) and MaxValue (exclusive)

            //Display a value from 0 to 50.
                                                             //max value, exclusive
            Console.WriteLine("A number from 0 to 50: " + rand.Next(51));
                                                                   //min inclusive, max exclusive
            Console.WriteLine("A number from 51 to 100: " + rand.Next(51, 101));

            //parameter - requirement for a method, listed in the parenthesis of the method definition
            //arguments - the values that are "passed" into the method when we invoke/call it.

            bool success = rand.Next(4) == 3; //Returns a 0 or a 1; if it's equal to 1, we get a bool of true. Otherwise, false.
            Console.WriteLine(success);

            //Random can be used to select a "random" item from a collection.
            int[] ints = { 55, 42, 37, 1, 16 };

            Console.WriteLine("The first index is: " + ints[0]);
            Console.WriteLine("The last index is: " + ints[^1]);//length - 1

            int index = rand.Next(ints.Length);//upper bound is exclusive, no need to subtract 1.
            Console.WriteLine("Random item: " + ints[index]);


            Console.WriteLine("Refactor: " + ints[new Random().Next(ints.Length)]);
            //Random rand2 = new Random();


            MethodsMenu.Main(args);

            #region Terminator
            Console.WriteLine("Press any key to exit the application...");
            Console.ReadKey();
            #endregion
        }
    }
}
