namespace _09_15.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class StudentExtensionMethods
    {
        //10.Implement the previous using the same query expressed with extension methods.

        public static void SortGroupExtensionMethod(this IList<Student> students)
        {
            var sorted = from st in students
                         where st.GroupNumber == 2
                         orderby st.FirstName
                         select st;

            Student.PrintInfo(sorted);
        }

        //14.Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.

        public static void MarksCountLinq(this List<Student> students, int count)
        {

            var studentsList = from st in students
                               where st.Marks.Count == count
                               select new { StudentName = String.Format("{0} {1}", st.FirstName, st.LastName), Marks = st.Marks };

            Console.WriteLine("Students with two marks: ");
            foreach (var student in studentsList)
            {
                Console.WriteLine(String.Format("{0}: {1}", student.StudentName, String.Join(", ", student.Marks)));
            }
            Console.WriteLine();
        }
    }
}
