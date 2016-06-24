using System;

namespace AnimalHierarchy
{
    public class Animal : ISound
    {
        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public static int AvarageAge (int sumAge, int length)
        {
            var result = sumAge / length;

            return result; 
        }

        public void Sound()
        {
            throw new NotImplementedException();
        }
    }
}
