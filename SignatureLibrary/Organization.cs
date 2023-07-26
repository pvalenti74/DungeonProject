using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity
{
    //By default, all additional classes in a Class Library are "internal."
    //Make it public! "Inaccessible due to its protection level" means you didn't change it to public
    public class Organization
    {
        //FIELDS: 
        //Access Modifier: private
        //Naming Convention: _camelCase

        private string _name;
        private DateTime _dateFounded;//Containment - using a complex type as an attribute of another type.
        private int _nbrOfMembers;
        private decimal _revenue;

        //PROPS:
        //Access Modifier: public
        //Naming Convention: PascalCase

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime DateFounded
        {
            get { return _dateFounded; }
            set { _dateFounded = value; }
        }

        public int NbrOfMembers
        {
            get { return _nbrOfMembers; }
            set
            {
                //custom business rules
                //The number of members must be greater than or equal to 0.
                //If it is less than 0, default the number to 1.
                if (value >= 0)
                {
                    _nbrOfMembers = value;
                }
                else
                {
                    _nbrOfMembers = 1;
                }
            }//end set
        }
        public decimal Revenue
        {
            get { return _revenue; }
            set { _revenue = value; }
        }//end Revenue

        //Paul: We went back to DataType harness to create the first Organization object (Avengers)

        //Constructors (CTORs) are specialized methods used to build an object of "this" type
        //They MUST be public
        //NO return type, not even void
        //They MUST have the same name as the class name.
        //A "Fully Qualified" CTOR will accept a parameter for each property that we have.
        public Organization(string name, DateTime dateFounded, int nbrOfMembers, decimal revenue)
        {
            //The parameters above should always be the camelCase version of the property name.
            //do NOT use fields inside the constructor.
            //Assign the parameter value into the Property.
            Name = name;
            DateFounded = dateFounded;
            NbrOfMembers = nbrOfMembers;
            Revenue = revenue;
            //By performing this assignment, the properties (gatekeepers) can perform their duty 
            //of assigning appropriate values into the fields using any business rules defined for the property.
        }//end FQ CTOR
        //IF/WHEN we make our own CTOR, we lose the default, parameterless one. To get it back, we have to create it again.
        public Organization()
        {
            //ctor -> tab
            //The default, parameterless ctor is REQUIRED if you want to use Object Initialization Syntax.
        }

        //Methods - Actions related to or utilizing properties of the object
        public override string ToString()
        {
            //return base.ToString(); Namespace.ClassName -> Charity.Organization
            //ToString is a non-static method (instance method). 
            //It has access to the object's properties from which it is called.
            return $"{Name}\nRevenue: {Revenue:c}\nMembers: {NbrOfMembers:n0}\nDate Founded: {DateFounded:d}\n";
        }

        //Paul: return to DataTypeHarness and code out the rest of the page.
    }
}
