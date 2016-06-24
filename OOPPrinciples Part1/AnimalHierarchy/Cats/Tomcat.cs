namespace AnimalHierarchy.Cats
{
    using System;

    public class Tomcat : Cat, ISound
    {
        public Tomcat (string name, int age, string sex = "male") : base(name, age, sex)
        {

        }
        
    }
}
