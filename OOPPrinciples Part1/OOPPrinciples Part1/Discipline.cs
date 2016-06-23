namespace OOPPrinciples_Part1
{
    using System;

    public class Discipline
    {
        private string name;
        private int numberOfLetures;
        private int numberOfExercises;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfLetures
        {
            get
            {
                return this.numberOfLetures;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("You can not have less then 1 lecture.");
                }
                this.numberOfLetures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("You can not have less then 1 exercise.");
                }
                this.numberOfExercises = value;
            }

        }


    }
}
