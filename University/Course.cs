using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    //MAKE IT PUBLIC!
    public class Course
    {
        //FIELDS - Funny
        //No business rules, so no fields.

        //PROPS - People
        public string Name { get; set; }
        public Dept Department { get; set; }

        //Each course may have multiple students or multiple books.
        //So, we can use a collection of those types for Course properties.
        public List<Student> Roster { get; set; }
        public List<Book> Curriculum { get; set; }
        public double CreditHours { get; set; }

        //CTORs - Collect
        /// <summary>
        /// Creates a fully-qualified Course object
        /// </summary>
        /// <param name="name">The name of this Course</param>
        /// <param name="department">The Dept Enum to which this course belongs</param>
        /// <param name="roster">A list of Students enrolled in this course</param>
        /// <param name="curriculum">A list of Books utilized in this course</param>
        /// <param name="creditHours">The number of credit hours earned through this course.</param>
        public Course(string name, Dept department, List<Student> roster, 
            List<Book> curriculum, double creditHours)
        {
            Name = name;
            Department = department;
            Roster = roster;
            Curriculum = curriculum;
            CreditHours = creditHours;
        }
        //METHODS - Monkeys

        public override string ToString()
        {
            //return base.ToString();
            //Create empty string variables to hold the information from our collections

            string students = "";
            string books = "";
            //iterate through the Curriculum and the Roster

            foreach (Book item in Curriculum)
            {
                books += item.Title + "\n";
                //we want to use the assignment operator (+=) to ADD the current value to
                //the string before assigning the completed string to the return.
            }

            foreach (Student item in Roster)
            {
                students += item.Name + "\n";
            }

            return $"Course: {Name}\t\tCredit Hours: {CreditHours:n1}\n" +
                   $"Department: {Department.ToString().Replace('_',' ')}\n" +
                   $"Curriculum:\n{books}\n" +
                   $"Roster:\n{students}\n";
        }
    }
}
