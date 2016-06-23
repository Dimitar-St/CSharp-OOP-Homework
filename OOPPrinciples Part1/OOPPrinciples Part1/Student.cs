namespace OOPPrinciples_Part1
{
    using System;

    public class Student : Classes
    {
        private string name;
        private string id; 

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The name is too short pleace add a new name.");
                }
                this.name = value;
            }
        }

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("The id was too short");
                }
                this.id = value;
            }
        } 


    }
}
