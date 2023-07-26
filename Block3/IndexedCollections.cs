using SignatureLibrary;
using System.Collections;

namespace Block3
{
    internal class IndexedCollections
    {
        static void Main(string[] args)
        {
            //Type Safe = Generic - Any type, but only one type per collection.
            //Not Type Safe = Non-Generic - Stores any mixture of datatypes as Objects

            Signatures.Header("Indexed Collections");

            #region Comparing types of collections
            /*
             * Collections are groups of objects stored together under one name. 
             * Some examples: Array[], ArrayList[], or List<> (aka "Typed List"). 
             * All of these collections store data that can be retrieved using an index number. 
             * Additionally, some of these collection types are Generic, meaning they are type safe. 
             * Alternatively, one is a non-generic meaning that it is not type safe. 
             */
            /* Array:
            * - Type safe (any type, but only one type per array) / Generic
            * - Length is fixed at declaration (can NOT change
            *  the length later in code)
            *  
            * ArrayList:
            * - Not type safe /Non-Generic
            * - It can store values of any datatype into 
            * any index in the collection. Mixing datatypes is acceptable.
            * This can cause issues, however, since the values are stored 
            * as type Object. This is called BOXING. To use the values as
            * their original datatype you have to cast them back to their
            * original datatype. This is called UNBOXING.
            * - Length IS expandable (CAN add/remove indexes after
            *  creation)
            * - NAMESPACE: System.Collections;
            * 
            * List (aka Typed List or List of T):
            * - Type safe (just like arrays) / Generic
            * - Expandable (CAN add/remove indexes after creation)
            * */
            #endregion

            //Quick Array Refresher
            string[] colors =
            {
                "red",             //0                ^7
                "royal blue",      //1                ^6
                "green",           //2                ^5
                "purple",          //3                ^4
                "cyan",            //4                ^3
                "mustard yellow",  //5                ^2
                "peachpuff"        //6                ^1
            };                     //colors.Length    ^0
            Console.WriteLine("\nARRAYS\n");
            foreach (string item in colors)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nARRAY LIST\n");

            ArrayList aList = new ArrayList()
            { "red", "royal blue", "green", "purple", 1, 42, DateTime.Now };
            Console.WriteLine("aList Length: " + aList.Count);//.Count is the same as array.Length
            aList.Add("House");
            Console.WriteLine("aList 'Count': " + aList.Count);

            Console.WriteLine("The last index holds: " + aList[^1]);
            Console.WriteLine((int)aList[4] + (int)aList[5]);//In order to use an object as its original datatype,
            //we must cast it back to that type (unboxing)
            Console.WriteLine($"{((DateTime)aList[6]).Year}");

            aList.Insert(1, "Triforce");
            foreach (object item in aList)
            {
                Console.WriteLine(item);
            }

            //Typed List / List<T>
            //List<datatype> listname = new List<datatype>();
            List<int> scores = new List<int>() { 12, 29, 0, 44 };
            scores.Add(100);
            //You CAN sort a typed list.
            //With an Array, you used a static method, Array.Sort(array)
            //For List<T>, you use an instance method, arrayName.Sort()
            scores.Sort();
            foreach (int item in scores)
            {
                Console.WriteLine(item);
            }
            //.Insert(Index, Item)
            //.RemoveAt(index)
            //.Remove(item)

            int x = 92;
            scores.Insert(3, x);
            foreach (int item in scores)
            {
                Console.WriteLine(item);
            }
            scores.RemoveAt(3);
            Console.WriteLine(scores[3]);
        }
    }
}