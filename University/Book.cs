namespace University
{
    public class Book
    {
        //FIELDS - Funny
        //No fields unless we have custom business rules. Instead,
        //we can use the "autoproperties" below.

        //PROPS - People
        //Auto-props can be created with prop > tab
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        //propfull > tab will create a "full" property with a private field and default accessors.


        //CTORs - Collect
        public Book(string title, string publisher, string isbn)
        {
            //Book b1 = new Book("Title", "Publisher", "0912389939")
            //Asssignment
            //Property = parameter;
            //PascalCase = camelCase
            Title = title;            
            Publisher = publisher;
            ISBN = isbn;
        }//FQ CTOR

        //METHODS - Monkeys
        public override string ToString()
        {
            //return base.ToString(); -> Namespace.ClassName -> University.Book
            return $"{Title} - {Publisher} - {ISBN}";
        }
    }
}