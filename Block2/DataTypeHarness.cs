using SignatureLibrary;
using Charity;

namespace Block2
{
    internal class DataTypeHarness
    {
        static void Main(string[] args)
        {
            Signatures.Header("Data Type Test Harness");
            #region Definitions

            //Class – Blueprint for an object. Classes are made up of members such as fields, properties constructors and methods
            //Fields – local variables that, by convention, are only available from inside the class and store information for a specific object (instance).
            //Properties – public variables that encapsulate the “getting” and “setting” of values into the fields of a specific object (instance).
            //Constructors – Specialized method that creates (instantiates) the object. It must have the same name of the class. In the body of the constructor is where the public properties are assigned the values input into the constructor.
            //Methods – Provide behavior or action for the class. Can be static (class-wide) or instance (relating to a specific object)

            #endregion

            //Complex datatypes need to be "constructed"
            //Custom types, like Arrays, DateTimes, etc, use "new" keyword to call
            //the Constructor method.
            //If you do not define a constructor of your own, you get a free, "default"
            //constructor with NO parameters.
            Volunteer v1 = new Volunteer();

            //We can assign values using the properties
            v1.Name = "Spider-Man";
            v1.YearsOfService = 12;
            v1.IsActive = true;
            //Assigning values to the properties calls the "setter" and stores the values in the _fields

            //We can call on them just like a regular variable using the properties' "getters"
            Console.WriteLine($"{v1.Name} has volunteered for {v1.YearsOfService} years.\n" +
                $"Status: {(v1.IsActive ? "Active" : "Inactive")}.");
            // condition ? truePart : falsePart

            //Object Initialization Syntax:
            Volunteer v2 = new Volunteer()
            {
                Name = "Batman",
                YearsOfService = 35,
                IsActive = false
            };
            
            Console.WriteLine($"{v2.Name} has volunteered for {v2.YearsOfService} years.\n" +
                $"Status: {(v2.IsActive ? "Active" : "Inactive")}.");

            //Paul: Start Here - Go create a new class in Charity called Organization.cs

            Console.WriteLine("\n\nOrganization Stuff\n\n");
            Organization o1 = new Organization()
            {
                Name = "Avengers",
                NbrOfMembers = 12,
                Revenue = 1_000_000,
                DateFounded = new DateTime(1974, 4, 18)
            };
            Console.WriteLine(o1);//default ToString() -> .GetType() -> Namespace.ClassName
            
            //Paul: Go back to Organization.cs and code the Constructor and the ToString()


            //If your custom object uses a complex object as a parameter, it is often
            //easiest to create that complex object first.
            DateTime date = new DateTime(1982, 11, 7);
            Organization o2 = new Organization("Justice League", date, 10, 750_231.89m);
            Console.WriteLine(o2);
            Signatures.Footer();

        }
    }
}