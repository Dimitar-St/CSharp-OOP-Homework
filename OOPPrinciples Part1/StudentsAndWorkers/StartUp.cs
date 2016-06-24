namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartUp
    {
        static void Main()
        {
            var listSrudent = new List<Student>()
            {
                new Student("Stamat", "Stamatov", 4),
                new Student("Pesho", "Grozev", 3),
                new Student("Stanka", "Drinkova", 6),
                new Student("Dimitar", "Gerov", 2),
                new Student("Konstantin", "Bojilov", 4),
                new Student("Gijka", "Topanova", 5),
                new Student("Orlin", "Tanev", 4),
                new Student("Evlogi", "Hristov", 6),
                new Student("Doncho", "Minkov", 6),
                new Student("Nikolay", "Kostov", 5),
                new Student("Steven", "Tsvetkov", 6),
                new Student("Cuki", "Cuklev", 6)
            };

            var sortStByGrades = listSrudent.OrderByDescending(st => st.Grade);

            Console.WriteLine("---------- sort students by grades ----------");

            foreach (var st in sortStByGrades)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " - " + st.Grade);
            }



            var listWorkers = new List<Worker>()
            {
                new Worker("Stamat", "Stamatov", 400, 8),
                new Worker("Pesho", "Grozev", 300, 6),
                new Worker("Stanka", "Drinkova", 600, 7),
                new Worker("Dimitar", "Popov", 200, 4),
                new Worker("Konstantin", "Bojilov", 500, 5),
                new Worker("Gijka", "Topanova", 900, 9),
                new Worker("Orlin", "Tanev", 400, 4),
                new Worker("Evlogi", "Hristov", 400, 6),
                new Worker("Doncho", "Minkov", 500, 2),
                new Worker("Nikolay", "Kostov", 600, 4),
                new Worker("Steven", "Tsvetkov", 600, 2),
                new Worker("Cuki", "Cuklev", 689, 6)
            };

            Console.WriteLine("---------- workers sort by money per hour ----------");

            var sortWorkersByMoneyPerHour = listWorkers.OrderByDescending(w => w.MoneyPerHour());

            foreach (var sortWorker in sortWorkersByMoneyPerHour)
            {
                Console.WriteLine("Fullname : " + sortWorker.FirstName + " " + sortWorker.LastName + " | Money per hour : " + sortWorker.MoneyPerHour());
            }


            var merge = new List<Human>();

            merge.AddRange(sortStByGrades);
            merge.AddRange(sortWorkersByMoneyPerHour);

            var sortByNames = merge.OrderByDescending(human => human.FirstName).ThenByDescending(human => human.LastName);

            Console.WriteLine("---------- all humans sorted by first name and last name ----------");

            foreach (var human in merge)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }

        }
    }
}
