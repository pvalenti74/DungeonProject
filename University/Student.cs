using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    //Make it public!
    public class Student
    {
        //FIELDS - Funny
        private double _gpa;
        //PROPS - People
        public double GPA
        {
            get { return _gpa; }
            set
            {
                //If the value passed is less than 0, GPA should be 0.
                //If the value is more than 4, GPA should be 4. 
                //Otherwise (default), GPA gets the value.
                switch (value)
                {
                    case < 0:
                        _gpa = 0;
                        break;
                    
                    case > 4:
                        _gpa = 4;
                        break;
                    
                    default:
                        _gpa = value;
                        break;
                }
            }
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public Dept Major { get; set; }
        public string Email { get; set; }

        //CTORs - Collect
        public Student(string name, int id, double gpa, Dept major, string email)
        {
            //Assignment
            //Prop = param
            Name = name;
            GPA = gpa;
            ID = id;
            Major = major;
            Email = email;
        }//FQ CTOR

        //METHODS - Monkeys
        public override string ToString()
        {
            //return base.ToString();
            string major = Major.ToString().Replace('_', ' ');
            return $"{Name}\tID: {ID}\n" +
                $"{major}\tGPA: {GPA:n1}\t{Email}";
            //n1 = Number 1 decimal place : 3.789 => 3.8
        }
    }
}
