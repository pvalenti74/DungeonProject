using SignatureLibrary;
using System.Collections;

namespace Block3
{
    internal class ReferenceCollections
    {
        static void Main(string[] args)
        {
            //Key, Value
            //The Key must be unique. It is serving as our "index," but we can define it ourselves.
            #region Reference Collections
            /*
             * Reference type collections store Key/Value pairs.
             * 
             * These types of collections are best suited for large collections where the order of entry and/or the indexed value do not matter. 
             * 
             * The key is a value that can uniquely identify an item in the collection. For example, a student ID could unquiely identify a student record. 
             * 
             * The value is the entire object that is being stored. 
             * 
             * Collection Initialization is available.
             * Looping through the Hashtable, the holding type is DictionaryEntry - both the key and the 
             * value go IN of type object.
             * 
             * Looping throughout the Dictionary, the holding type KeyValuePair - both the key and the value
             * are strongly typed in this collection.
             */
            #endregion

            #region Employee Objects
            //Create 5 Employee objects

            Employee e1 = new Employee(111111, "Mike",
                "Baxter", "Marketing Genius",
                new DateTime(2011, 1, 1), true);

            Employee e2 = new Employee(222222, "Kristin",
                "Baxter", "Restaurant Manager",
                new DateTime(2011, 1, 1), false);

            Employee e3 = new Employee(333333, "Ed",
                "Alzate", "Business Owner",
                new DateTime(2011, 1, 1), true);

            Employee e4 = new Employee(444444, "Kyle",
                "Anderson", "Gopher",
                new DateTime(2011, 1, 1), false);

            Employee e5 = new Employee(555555, "Chuck",
                "Larabee", "Security Manager",
                new DateTime(2011, 1, 1), true);
            #endregion

            Signatures.Header("Reference Collections");

            Console.WriteLine("Hashtable: Non-generic reference collection");
            Hashtable empsHT = new Hashtable()
            {
                //{ key, value },
                { e1.ID, e1 }, //both items are stored as objects
                { e2.ID, e2 },
                { e3.ID, e3 },
                //{ "House", 42 }
                { e4.ID, e4 }
            };

            //.Add() exists for Hashtable as well
            empsHT.Add(e5.ID, e5);

            foreach (DictionaryEntry item in empsHT)
            {
                Console.WriteLine(((Employee)item.Value).FirstName);
            }

            Console.WriteLine("\nDictionary\n");
            //Dictionary<TKey, TVal> name = new Dictionary<TKey, TVal>();
            Dictionary<int, Employee> emps = new()
            {
                                //{ key, value },
                { e1.ID, e1 }, //both items are stored as objects
                { e2.ID, e2 },
                { e3.ID, e3 },
                //{ "House", 42 },
                { e4.ID, e4 }
            };
            foreach (KeyValuePair<int, Employee> item in emps)
            {
                Console.WriteLine(item.Value.ID + " " + item.Value.FirstName);
            }

            emps.Remove(e1.ID);

            emps.Clear();
            Signatures.Footer();
        }//end Main()
    }//end reference collections

    public class Employee
    {
        //FIELDS
        private int id;
        private string firstName;
        private string lastName;
        private string jobTitle;
        private DateTime dateOfHire;
        private bool isDirectDeposit;

        //PROPERTIES
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        public DateTime DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }
        public bool IsDirectDeposit
        {
            get { return isDirectDeposit; }
            set { isDirectDeposit = value; }
        }

        //CONSTRUCTORS
        public Employee(int id, string fName, string lName, string title, DateTime hireDate, bool isDirectDeposit)
        {
            ID = id;
            FirstName = fName;
            LastName = lName;
            JobTitle = title;
            DateOfHire = hireDate;
            IsDirectDeposit = isDirectDeposit;
        }

        //METHODS
        public override string ToString()
        {
            return string.Format(
                $"ID: {ID}\nName: {FirstName} {LastName}\nJob Title: {JobTitle}\nDate of Hire: {DateOfHire:d}" +
                //Ternary operator: 3parts
                //[Condition]      ? [true]: [false]
                $"\nDirect Deposit?: {(IsDirectDeposit ? "Enabled" : "Disabled")}");
        }//end tostring
    }//end employee
}//end namespace
