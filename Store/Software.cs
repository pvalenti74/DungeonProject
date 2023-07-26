using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    //Make it public and inherit from Product
    public class Software : Product
    //public class named software that extends product.
    {

        //FIELDS - Funny
        //None

        //PROPS - People
        //Inherited props are already taken care of in the Product class.
        public OS OperatingSystem { get; set; }
        public string Version { get; set; }
        
        //CTORs - Collect
        public Software(string name, decimal price, string description, bool isInStock, OS operatingSystem, string version) 
            : base(name, price, description, isInStock)
        {
            //Handle only the unique assignment.
            OperatingSystem = operatingSystem;
            Version = version;
        }
        //METHODS - Monkeys

        public override string ToString()
        {
            return base.ToString() + $"\nOS: {OperatingSystem}\t\tVersion: {Version}";
        }
        //Let's assume that Software has a 20% discount during the holidays.
        //MINI LAB! Override the Discount method to return a 20% discount.
        public override decimal CalcHolidayDiscount()
        {
            return Price * .8m;
        }
    }
}
