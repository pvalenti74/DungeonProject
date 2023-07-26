namespace Charity
{
    public class Volunteer
    {
        //This is a Data Type class, so it DOES NOT GET an SVM.
        //Class members : Fields, Properties, Constructors, Methods
        //                Funny,  People,     Collect,      Monkeys

        //FIELDS - Where the data is actually stored
        //Naming convention : _camelCase
        //Access modifier : private
        //Fields are just variables used to store information about an object of this type.
        private string _name;
        private byte _yearsOfService;
        private bool _isActive;

        //Properties - How we access the data stored in the fields
        //We can protect the fields by establishing "business rules" for the 
        //retrieval (get) or assignment (set) of the fields.
        //Naming convention : PascalCase version of the _camelCase fieldname
        //Access modifier : public
        public string Name
        {
            get { return _name; }
            set
            {
                /*we could include rules to restrict what sort of information is allowed*/
                _name = value;
            }
        }//end name

        public byte YearsOfService
        {
            get { return _yearsOfService; }
            set { _yearsOfService = value; }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        //properties are often called "gatekeepers" as they serve as the protectors
        //of the _fields.
        //Encapsulation: Protecting data/functionality with "layers" of access.
    }
}