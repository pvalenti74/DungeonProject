namespace SignatureLibrary
{
    public class Signatures
    {
        //We created the SignatureLibrary as a C# Class Library project.
        //This type of project compiles to a DLL (Dynamic Link Library).
        //The first class in a DLL is always public by default.
        //All subsequent classes will default to the access modifier "internal" and are inaccessable outside of this library.

        /// <summary>
        /// Print a header and change the title at the start of a section.
        /// </summary>
        /// <param name="title">Title to Display</param>
        public static void Header(string title)
        {
            Console.Title = "-=-=-= " + title.ToUpper() + "=-=-=-";
            Console.WriteLine("-= CSF2: Breaking New Ground on " + title.ToUpper() + " =-");
        }//end Header()

        public static void Footer()
        {
            Console.WriteLine("\n\nAll code has completed. Press any key to terminate the program...");
            Console.ReadKey(true);
        }//end Footer()

        //To use this class in another project:
        //1) The class MUST be public
        //2) You MUST add a reference to this class library in any projects that "consume" it.
        //3) You CAN add a using statement to make using the class a little easier.
    }//end class
}//end namespace