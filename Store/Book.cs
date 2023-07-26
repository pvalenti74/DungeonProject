using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    //Access is defaulted to internal -- MAKE IT PUBLIC!
    public class Book : Product
    {
        //By adding the ": Product" above, we have designated Book as a child of Product.
        //Inheritance: Almost everything in Product now exists in Book
        //We inherit Fields, Props, and Methods (not CTORS)

        //In C# inheritance, we can only have ONE direct parent. We can have infinite child classes. 
        //relationship: parent/child (most used), base/derived (official), superclass/subclass

        //FIELDS - Funny
        //no business rules, no fields

        //PROPS - People
        //we get ALL of the props from Product. So, the only props we need to handle
        //are the unique Book props.
        public string Author { get; set; }
        public int Pages { get; set; }

        //CTORs - Collect
        //We do not inherit constructors from the parent class.
        //Because we inherit the properties, we CAN pass values back to the parent class
        //to handle the assignment (PascalCase = camelCase)
        public Book(string name, decimal price, string description, bool isInStock, 
            string author, int pages) : base(name, price, description, isInStock)
        {
            //we COULD do all of the assignment here. However, we can save time by passing these parameters back to the parent constructor.
            //To do this, we added ": base()" after the parameter list above.
            //Now, assign the unique book props.
            Author = author;
            Pages = pages;
        }

        //METHODS - Monkeys
        public override string ToString()
        {
            //For this ToString(), we will keep the formatting from the parent (base) class
            //and simply concatenate our unique book properties.
            return base.ToString() + $"\nAuthor: {Author}\nPages: {Pages:n0}";
        }

        public override decimal CalcHolidayDiscount()
        {
            //return base.CalcHolidayDiscount(); -> 5% discount
            //Let's assume that all books get a 10% discount.
            return Price * .9m;
        }
    }
}
