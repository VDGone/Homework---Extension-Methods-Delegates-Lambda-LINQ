namespace _09_15.StudentGroups
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TestStudent
    {

        static void Main()
        {
            var listOfStudents = new List<Student>()
            { 
                new Student ("Angel", "Geshev", "423506","+3598855885588", "AngelG@abv.bg", 1, new List<double>{3, 5, 6}),
                new Student ("Deqn", "Balev", "424544", "02/88887", "DBalev@Gmail.com", 1, new List<double>{4, 5, 6}),
                new Student ("Angel", "Marinov", "424506", "+3598882838877", "A_Marinov@Gmail.com", 2, new List<double>{5, 5}),
                new Student ("Boris", "Voinikov", "424542", "+3598878840087", "DBalev@Gmail.com", 1, new List<double>{6, 6}),
                new Student ("Galin", "Ivanov", "424534", "02/8558887", "G_I@abv.bg", 2, new List<double>{3, 2, 6}),
                new Student ("Zasmqn", "Zasmqnov", "424541", "+3598883428887", "Zasmqnov@Gmail.com", 3, new List<double>{6, 6, 6}),
                new Student ("Iglika", "Cvetanova", "424537", "02/4777487", "Cvetanova@Gmail.com", 3, new List<double>{6, 6}),
                new Student ("Minka", "Breznikova", "424533", "+3598888123887", "Minka_b@abv.bg", 2, new List<double>{2, 3}),
                new Student ("Mariq", "Aleksandrova", "424530", "+3598888855587", "Mariq_Aleks@Gmail.com", 1, new List<double>{6, 5, 6})
            };

            Console.WriteLine("Sorted by group: ");
            Student.SortByGroup(listOfStudents);
            Console.WriteLine("\n\rSorted by first name: ");
            Student.sortByFirstNameLinqQuery(listOfStudents);
            StudentExtensionMethods.SortGroupExtensionMethod(listOfStudents);
            Console.WriteLine("\n\rSorted by email: ");
            Student.SortByEmailLinq(listOfStudents, "abv.bg");
            Console.WriteLine(Student.EmailString(listOfStudents, "abv.bg"));
            Console.WriteLine("\n\rSorted by phone number: ");
            Student.SortByPhoneNumber(listOfStudents, "02");
            Console.WriteLine("\n\rSorted by mark: ");
            Student.SortByMark(listOfStudents, 6);
            listOfStudents.MarksCountLinq(2);
            Student.SortBySigningIn2006(listOfStudents);   
            
        }
    }
}
