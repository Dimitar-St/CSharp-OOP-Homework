namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using Cats;
    using Dogs;

    class StartUp
    {
        static int Sum (List<Animal> collection)
        {
            var result = 0;
            
            foreach (var animal in collection)
            {
                result += animal.Age;
            }

            return result;
        }

        static void Main()
        {

            // Avarage age for dogs

            var listDogs = new List<Animal>()
            {
                new Dog("Rex", 3, "male"),
                new Dog("Riza", 4, "female"),
                new Dog("Sharo", 2, "male"),
                new Dog("Pesho", 8, "male"),
                new Dog("Diksi", 8, "female")
            };

            var avarageAgeDogs = Animal.AvarageAge(Sum(listDogs), listDogs.Count);

            Console.WriteLine(avarageAgeDogs);

            // Avarage age for tomcats and kittens

            var listTomCats = new List<Animal>()
            {
                new Tomcat("Kitty", 2),
                new Tomcat("Pesho", 3),
                new Tomcat("Gosho", 2),
                new Tomcat("Stamat", 6)
            };

            var avarageAgeTomcat = Animal.AvarageAge(Sum(listTomCats), listTomCats.Count);

            Console.WriteLine(avarageAgeTomcat);

            var listKittens = new List<Animal>()
            {
                new Kitten("Pesho", 1),
                new Kitten("Stamat", 4),
                new Kitten("Gosho", 2),
                new Kitten("Penka", 6),
                new Kitten("Radoslav", 8)
            };

            var avarageAgeKittens = Animal.AvarageAge(Sum(listKittens), listKittens.Count);

            Console.WriteLine(avarageAgeKittens);

            // Avarage age fot frog

            var listFrogs = new List<Animal>()
            {
                new Frog("Gosho", 3, "male"),
                new Frog("Pesho", 2, "male"),
                new Frog("Stanka", 1, "female"),
                new Frog("Ivan", 2, "male"),
                new Frog("Cuki", 7, "male")
            };

            var avarageAgeForgs = Animal.AvarageAge(Sum(listFrogs), listFrogs.Count);

            Console.WriteLine(avarageAgeForgs);

            var tomcat = new Tomcat("Pedso", 3);

            tomcat.Sound();


        }
    }
}
