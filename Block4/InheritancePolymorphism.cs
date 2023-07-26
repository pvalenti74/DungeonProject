using Store;//Added a reference and a using statement to the Store project
namespace Block4
{
    internal class InheritancePolymorphism
    {
        static void Main(string[] args)
        {
            #region Mini Lab - Week 2 / Monday
            //MINI LAB
            //Add a class library project to the solution. Call it "Store."
            //Change the name of the first class (Class1) to "Product.cs"

            //Build a blueprint for a Product object using the following class members.
            //No fields.
            //Auto Props: string for the Name
            //       decimal for the Price
            //       string for the Description
            //       bool for IsInStock
            //Fully-Qualified Constructor
            //"Nicely-formatted" ToString() override.
            #endregion

            Product p1 = new("Iocane Powder", 299.99m, "Odorless, tasteless, and dissolves instantly in liquid.");
            Console.WriteLine(p1);

            //CalcHolidayDiscount is an instance method because it needs information about a 
            //specific product (it needs the Price to perform the calculation)
            //In order to use instance methods, invoke them from the "instance" (variable) name.
            Console.WriteLine($"{p1.Name}'s discounted price is {p1.CalcHolidayDiscount():c}");

            //DisplayReturnPolicy() is a static method, because it doesn't need any information
            //about a specific Product. Static methods are invoked from the class name.
            Console.WriteLine(Product.DisplayReturnPolicy());

            Console.WriteLine("\n**** BOOKS ****\n");
            Book bk1 = new("Castle Storming Procedures", 19.99m, "The best ways to have fun storming the castle", true, "Wesley Farmboy", 100);
            Console.WriteLine(bk1);

            Console.WriteLine($"{bk1.Name}'s discounted price is {bk1.CalcHolidayDiscount():c}");
            //We didn't define DisplayReturnPolicy() in the Book class, but it's still available to 
            //be called from the Book class because of inheritance.
            Console.WriteLine(Book.DisplayReturnPolicy());

            Console.WriteLine("\n***** SOFTWARE *****\n");
            Software s1 = new("Frogger", 5.99m, "Old school cool", false, OS.Android, "3.1");
            Console.WriteLine(s1);
            Console.WriteLine($"{s1.Name}'s discounted price is {s1.CalcHolidayDiscount():c}");
            Console.WriteLine(Software.DisplayReturnPolicy());

            //It is not incorrect to say that, due to inheritance, Books and Software are simply more
            //specific types of Product. This means that if we had a method that required a Product as a parameter,
            //we could use it with a Product, a Book, or a Software.
            //We can store a child class as any of its parent types.
            Object o1 = s1;//This is a duplicate reference. Try to avoid it, but it's a good example of storing something as a parent type.
            Console.WriteLine(o1);

            List<Product> products = new() { p1, bk1, s1 };
            p1.Price = 100;
            bk1.Price = 100;
            s1.Price = 100;
            Console.WriteLine("\n******** POLYMORPHISM *************\n");
            foreach (Product item in products)
            {
                Console.WriteLine(item.Name + $" is normally priced: {item.Price:c}. " +
                    $"Discounted at {item.CalcHolidayDiscount():c}");
                //Even though our Book and Software were implicitly cast as Products when added to the collection,
                //we still see the correct output for each specific type.
                //This is thanks to a process called "Late Binding." At runtime, .NET examines each object and
                //determines the actual type of each object (GetType()) and chooses the correct override where appropriate.
            }

        }
    }
}
