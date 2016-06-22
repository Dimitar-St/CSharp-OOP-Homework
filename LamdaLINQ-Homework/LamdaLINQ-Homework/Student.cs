namespace LamdaLINQ_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public int FN { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }
        public string Marks { get; set; }
        public int GroupNumber { get; set; }


        public Student(string fname, string lname, int age)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }

        public Student (string fname, string lname, int fn, int tel, string email, string marks)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
        }

        public Student(string firstName, int group)
        {
            this.FirstName = firstName;
            this.GroupNumber = group;
        }

    }
}
