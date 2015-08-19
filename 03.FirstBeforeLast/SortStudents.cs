namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortStudents
    {
        //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
        //Use LINQ query operators.

        public static void SortStudentsByName (IList<Student> studentGroup)
        {
            var sorted = 
                from st in studentGroup
                where st.FirstName.CompareTo(st.LastName) < 0
                orderby st.FirstName
                select st;

            PrintInfo(sorted);
        }

        //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

        public static void SortByAgeRange(IList<Student> studentsAge)
        {
            var sorted =
                from st in studentsAge
                where st.Age > 17 && st.Age < 25
                orderby st.Age
                select st;

            PrintInfo(sorted);
        }

        //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first 
        //name and last name in descending order.
        //Rewrite the same with LINQ.

        public static void SortByFirstNameDescending(IList<Student> studentsName)
        {
            var sorted =
                from st in studentsName
                orderby st.FirstName descending//,orderby st.LastName descending
                select st;
            PrintInfo(sorted);
        }

        public static void SortByLastNameDescending(IList<Student> studentsName)
        {
            var sorted =
                from st in studentsName
                orderby st.LastName descending
                select st;
            PrintInfo(sorted);
        }
        public static void PrintInfo(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }

        static void Main()
        {
            var listOfStudents = new List<Student>()
            { 
                new Student ("Angel", "Geshev", 16),
                new Student ("Deqn", "Balev", 20),
                new Student ("Angel", "Marinov", 25),
                new Student ("Boris", "Voinikov", 24),
                new Student ("Galin", "Ivanov", 18),
                new Student ("Zasmqn", "Zasmqnov", 26),
                new Student ("Iglika", "Cvetanova", 22),
                new Student ("Minka", "Breznikova", 23),
                new Student ("Mariq", "Aleksandrova", 30)
            };

            var descendingSort = listOfStudents.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            Console.WriteLine("Sorted by first name: ");
            SortStudentsByName(listOfStudents);
            Console.WriteLine("\n\rSorted by age: ");
            SortByAgeRange(listOfStudents);
            Console.WriteLine("\n\rSorted descending by first name LINQ method: ");
            SortByFirstNameDescending(listOfStudents);
            Console.WriteLine("\n\rSorted descending by last name LINQ method: ");
            SortByLastNameDescending(listOfStudents);
            Console.WriteLine("\n\rSorted descending by first name Lambda method: ");
            foreach(var element in descendingSort)
            {
                Console.WriteLine(element);
            }
            
        }
    }
}
