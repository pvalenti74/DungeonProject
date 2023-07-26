namespace Store
{
    //The first class in a Class Library project is public. No need to change it!
    public class Product
    {
        //MINI LAB
        //FIELDS: None

        //Auto Props
        public string Name { get; set; } //"" String.Empty
        public decimal Price { get; set; }//0
        public string Description { get; set; }
        public bool IsInStock { get; set; }//false

        //Fully Qualified Constructor
        public Product(string name, decimal price, string description, bool isInStock)
        {
            Name = name;
            Price = price;
            Description = description;
            IsInStock = isInStock;
        }
        public Product(string name, decimal price, string description/*, bool isInStock*/)
        {
            Name = name;
            Price = price;
            Description = description;
            IsInStock = true;
            //This constructor doesn't have a parameter for "IsInStock." We COULD leave that 
            //property unassigned (false)
            //Instead, we're going to assume that every new product we create with this ctor 
            //is already in stock.
        }


        //Nicely formatted ToString() override
        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}\t{Price:C}\n" +
                   $"{Description}\n" +
                   //Ternary operator to show in-stock status
                   // (condition ? truePart : falsePart)
                   $"{(IsInStock ? "In" : "Out of")} Stock";
        }

        //Static v Instance
        //If the method needs to access information about a specific INSTANCE of an object, make it instance. (no keyword)
        //If the method pertains to the entire class generally (no instance information) mark it "static"

        public static string DisplayReturnPolicy()
        {
            return "Return Policy: All returns must be processed within 90 days of purchase.";
        }

        //Let's calculate the discount of an object. To do that, we need to know the price.
        public virtual decimal CalcHolidayDiscount()
        {
            //The "virtual" keyword allows (but does not require) a method to be overridden in a child class.

            //Price * (1.00 - Discount)
            return Price * .95m;
        }
    }
}