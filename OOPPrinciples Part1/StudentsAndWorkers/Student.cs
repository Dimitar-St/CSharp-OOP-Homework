namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private int grade;

        public Student(string fName, string lName, int grade)
            : base(fName, lName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

    }
}
