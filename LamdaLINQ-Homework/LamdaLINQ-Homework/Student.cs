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
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Marks { get; set; }
        public int GroupNumber { get; set; }


        public Student(string fname, string lname, int age)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }

        //public Student(string fname, string lname, string tel)
        //{
        //    this.FirstName = fname;
        //    this.LastName = lname;
        //    this.Tel = tel;
        //}

        // for task 11
        public Student (string firstName, string email)
        {
            this.FirstName = firstName;
            this.Email = email;
        }

        // for task 9 and 10
        public Student(string firstName, int group)
        {
            this.FirstName = firstName;
            this.GroupNumber = group;
        }

        //for task 13
        public Student (string marks, string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Marks = marks;
        }
         

  


    }
}
