namespace LamdaLINQ_Homework
{
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    public static class Extensions
    {
        // Task 1

        public static StringBuilder Subtring(this StringBuilder collection, int index, int length)
        {
            var result = new StringBuilder();

            for (int i = index; i <= length; i++)
            {
                result.Append(collection[i]);
            }

            return result;
        }

        // Task 2

        // Min

        public static T Min<T>(this IEnumerable<T> collection)
        {
            T min = collection.ElementAt(0);

            foreach (T el in collection)
            {
                if (min > (dynamic)el)
                {
                    min = el;
                }
            }

            return min;
        }

        // Max 

        public static T Max<T>(this IEnumerable<T> collection)
        {
            T max = collection.ElementAt(0);

            foreach (T el in collection)
            {
                if (max < (dynamic)el)
                {
                    max = el;
                }
            }

            return max;
        }

        // Sum 

        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;

            for (int i = 0; i < collection.Count(); i++)
            {
                sum += (dynamic)collection.ElementAt(i);
            }

            return sum;
        }

        // Avarage

        public static double Avarage<T>(this IEnumerable<T> collection)
        {
            T sum = collection.Sum();

            double avarage = (dynamic)sum / collection.Count();

            return avarage;
        }

        // Product 

        public static T Product<T> (this IEnumerable<T> collection)
        {
            dynamic product = 1;

            for (int i = 0; i < collection.Count(); i++)
            {
                product *= (dynamic)collection.ElementAt(i); 
            }

            return product;
        }

        // Divisivble by  7 and 3

        public static int[] divisble (this int[] array)
        {
            var result = new int[array.Length];

            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i] % 7 == 0 || array[i] % 3 == 0)
                {
                    result[i] = array[i];
                }
                else
                {
                    result[i] = 0;
                }
            }

            return result;
        }

        // Student groups extensions

        public static List<Student> GetGroupAndSortName (this List<Student> students)
        {
            var result = 
                (from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student).ToList();

            return result;
        }


    }
}
