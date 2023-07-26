using SignatureLibrary;
using University;

namespace Block4
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            Signatures.Header("Creating New Types");

            Console.WriteLine("\n--BOOKS--\n");
            Book bk1 = new Book("The Count of Monte Cristo", "Penguin Publishing", "0486456439");
            Console.WriteLine(bk1);
            Book bk2 = new Book("Xanathar's Guide to Everything", "Wizards of the Coast", "0786966114");
            //Almost anytime you see the "new" keyword, you're calling a CTOR for a complex object
            Console.WriteLine(bk2);

            Console.WriteLine("\n--STUDENTS--\n");
            Student s1 = new("Derek Zoolander", 123, 0.4, Dept.Finger_Painting, "bluesteele@aol.com");
            Console.WriteLine(s1);
            Student s2 = new("Hansel", 456, 3.8, Dept.Break_Dance_Fighting, "sohotrightnow@yahoo.com");
            Console.WriteLine(s2);

            Console.WriteLine("\n--COURSE--\n");
            //It is often easiest to create our collections before using them in a constructor.
            //Otherwise, we have to use collection initialization inside of the constructor argument list, which can be super annoying to read.
            List<Student> students = new() { s1, s2 };
            List<Book> books = new() { bk1, bk2 };

            Course biz101 = new("Selling Is As Selling Does", Dept.Nerd_Whispering,
                students, books, 12);
            Console.WriteLine(biz101);


            Signatures.Footer();
        }
    }
}