namespace LamdaLINQ_Homework
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
            // Предварително се извинявам за лошите имена на променливите и че съм напписал така LINQ queries-тата просто гледах по-стара лекция 
            // Това домашно не е пълно. Само до 13 задача.
            /*
            Problem 1. StringBuilder.Substring

            Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
            */

            var test = new StringBuilder();

            test.Append("test");

            Console.WriteLine(test.Subtring(0, 2));


            /*
                Problem 2. IEnumerable extensions

                Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
            */

            var testIEnumerableEx = new List<int>() { 1, 2 };

            Console.WriteLine("Sum : {0}", testIEnumerableEx.Sum());
            Console.WriteLine("Avarage : {0:f2}", testIEnumerableEx.Avarage());
            Console.WriteLine("Product : {0}", testIEnumerableEx.Product());
            Console.WriteLine("Min : {0}", testIEnumerableEx.Min());
            Console.WriteLine("Max : {0}", testIEnumerableEx.Max());

            /*
            Problem 3. First before last

            Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            Use LINQ query operators.
            */

            Student firstStudent = new Student("Pesho", "Peshov", 19);
            Student secondStudet = new Student("Mitko", "Peshov", 89);
            Student thirdStudent = new Student("Stamat", "Grigorov", 22);
            Student fourthStudent = new Student("Stilian", "Dechev", 45);

            /*
            Problem 4. Age range

            Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            */

            Console.WriteLine(new string('-', 50));

            var listStudent = new List<Student>();

            listStudent.Add(firstStudent);
            listStudent.Add(secondStudet);
            listStudent.Add(thirdStudent);
            listStudent.Add(fourthStudent);

            var ageRange =
                (from student in listStudent
                 where student.Age > 18 && student.Age < 24
                 select student.FirstName + " " + student.LastName).ToList();

            foreach (var names in ageRange)
            {
                Console.WriteLine(names);
            }

            /* 
             Problem 5. Order students

             Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
             Rewrite the same with LINQ.
            */

            Console.WriteLine("--------Task 5----------");

            // LINQ queries
            Console.WriteLine("-------LINQ--------");

            var sortWithLinq =
                    (from student in listStudent
                     orderby student.FirstName, student.LastName
                     select student).ToList();

            foreach (var names in sortWithLinq)
            {
                Console.WriteLine(names.FirstName + " " + names.LastName);
            }

            // Lamda expressions

            Console.WriteLine("--------Lamda----------");

            var sortWithLamda = listStudent
                                .OrderBy(student => student.FirstName)
                                .ThenBy(student => student.LastName)
                                .ToList();

            foreach (var names in sortWithLamda)
            {
                Console.WriteLine(names.FirstName + " " + names.LastName);
            }

            /* 
            Problem 6. Divisible by 7 and 3

            Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
            */

            Console.WriteLine("--------Task 6----------");

            int[] numbers = new int[] { 12, 27, 40 };
            var numbersList = numbers.ToList();

            foreach (var el in numbers.divisble())
            {
                Console.WriteLine(el);
            }

            /* 
            Problem 7. Timer

            Using delegates write a class Timer that can execute certain method at each t seconds.
            */

            // Uncomment
            //Timer.SetInterval(new Action(() => Timer.CurrentDate()), 1);

            /*
            Problem 9. Student groups

            Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
            Create a List<Student> with sample students. Select only the students that are from group number 2.
            Use LINQ query. Order the students by FirstName. 
            */
            Console.WriteLine("--------Task 9----------");

            Console.WriteLine(new string('-', 50));

            Student group1 = new Student("Tosho" , 3);
            Student group2 = new Student("Gosho" , 2);
            Student group4 = new Student("Acho", 2);
            Student group3 = new Student("Ivan" , 1);

            var listStudents = new List<Student>();

            listStudents.Add(group1);
            listStudents.Add(group2);
            listStudents.Add(group3);
            listStudents.Add(group4);

            var selectGroup =
                (from student in listStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student).ToArray();
             

            for (int i = 0; i < selectGroup.Length; i++)
            {
                Console.WriteLine("First name : " + selectGroup[i].FirstName + " and " + selectGroup[i].GroupNumber);
            }

            /*
            Problem 10. Student groups extensions

            Implement the previous using the same query expressed with extension methods.
            */
            Console.WriteLine("--------Task 10----------");
            
            var task = listStudents.GetGroupAndSortName();

            foreach (var st in task)
            {
                Console.WriteLine("First name" + st.FirstName + " and group number" + st.GroupNumber);
            }

            /* 
            Problem 11. Extract students by email

            Extract all students that have email in abv.bg.
            Use string methods and LINQ.
            */

            var firstStEmail = new Student("Mitko", "gmail.com");
            var secondStEmail = new Student("Pesho", "abv.bg");
            var thirdStEmail = new Student("Petka", "abv.bg");
            var fourthStEmail = new Student("Getka", "mail.bg");

            var extractEmailStudent = new List<Student>();

            extractEmailStudent.Add(firstStEmail);
            extractEmailStudent.Add(secondStEmail);
            extractEmailStudent.Add(thirdStEmail);
            extractEmailStudent.Add(fourthStEmail);


            var stEmailABV =
                            from stEmail in extractEmailStudent
                            where stEmail.Email == "abv.bg"
                            select stEmail;

            /* 
            Problem 12. Extract students by phone

            Extract all students with phones in Sofia.
            Use LINQ.
            */

            //var firstSt = new Student("Banio", "Avanov", "02-413-4130");
            //var secondSt = new Student("Pesho", "Avanov", "07-409-3313");
            //var thirdSt = new Student("Abio", "Konev", "05-352-6526");

            //var studentsArr = new List<Student>();

            //studentsArr.Add(firstSt);
            //studentsArr.Add(secondSt);
            //studentsArr.Add(thirdSt);

            //var extractByPhone = studentsArr.Where(s => s.Tel.IndexOf("02") == 0)
            //                               .ToList();

            //Console.WriteLine("Students with phone in Sofia");

            //foreach (var std in extractByPhone)
            //{
            //    Console.WriteLine(std.FirstName + " " + std.LastName);
            //}

            /* 
            Problem 13. Extract students by marks

            Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            Use LINQ.
            */

            var firstStMark = new Student("5", "Banio", "Avanov");
            var secondStMark = new Student("6", "Pesho", "Avanov");
            var thirdStMark = new Student("3", "Abio", "Konev");

            var studentsArrMarks = new List<Student>();

            studentsArrMarks.Add(firstStMark);
            studentsArrMarks.Add(secondStMark);
            studentsArrMarks.Add(thirdStMark);

            var extractByExcellentMark = studentsArrMarks.Where(s => s.Marks.Contains("6"))
                                                 .Select(x => new
                                                 {
                                                     FullName = x.FirstName + " " + x.LastName,
                                                     Marks = x.Marks
                                                 });

            Console.WriteLine("Students with at least one excellent mark");

            foreach (var std in extractByExcellentMark)
            {
                Console.WriteLine(std.FullName);
            }

            Console.WriteLine();

        }
    }
}
