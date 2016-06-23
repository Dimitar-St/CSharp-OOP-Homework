namespace OOPPrinciples_Part1
{
    using System;

    public class Teacher : Discipline
    {
        private string name;
        
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
                    throw new ArgumentException("This is too shirt pleace add a new teacher name.");
                }
                this.name = value;
            }
        }


    }
}
