namespace _09_15.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {

        //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        //Create a List<Student> with sample students. Select only the students that are from group number 2.
        //Use LINQ query. Order the students by FirstName.

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FN { get; set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public List<double> Marks { get; private set; }
        public int GroupNumber { get; private set; }

        public Student(string firstName, string lastName, string fn, string tel, string email, int groupNumber, List<double> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = new List<double>(marks);
            this.GroupNumber = groupNumber;
        }
        //problem 9
        public static void SortByGroup(IList<Student> studentsGruop)
        {
            var sorted =
                from st in studentsGruop
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;
            PrintInfo(sorted);
        }

        public static void sortByFirstNameLinqQuery(IList<Student> studentsFirstName)
        {
            var queryAllStudents = from st in studentsFirstName
                                   orderby st.FirstName
                                   select st;
            PrintInfo(queryAllStudents);
        }

        //11.Extract all students that have email in abv.bg. Use string methods and LINQ.
        public static IEnumerable<Student> EmailString(List<Student> students, string emailHost)
        {
            return students
                .Where(
                        x => x.Email.ToString()
                        .Substring(x.Email.ToString().IndexOf("@") + 1)
                        == emailHost)
                .OrderBy(x => x.FirstName).ToArray();
        }

        public static void SortByEmailLinq(IList<Student> students, string emailHost)
        {
            var mailstudents = from st in students
                               where st.Email.Contains(emailHost)
                               orderby st.FirstName
                               select st;
            PrintInfo(mailstudents);
        }
        //12.PhoneNumber
        public static void SortByPhoneNumber(IList<Student> students, string tel)
        {
            var telOfStudent = from st in students
                            where st.Tel.Contains(tel)
                            orderby st.FirstName
                            select st;
            PrintInfo(telOfStudent);
        }

        //13.Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
        //Use LINQ.

        public static void SortByMark(IList<Student> students, double mark)
        {
            var MarkOfStudent = from st in students
                                where st.Marks.Contains(mark)
                                orderby st.FirstName
                                select st;
            PrintInfo(MarkOfStudent);
        }

        public static void SortBySigningIn2006(IList<Student> students)
        {
            var sorted =
                from st in students
                where st.FN.EndsWith("06")
                select st;

            Console.WriteLine("Marks of students enrolled in 2006");

            foreach (Student student in sorted)
            {
                Console.WriteLine(student.ToString() +
                    "-" + string.Join(", ", student.Marks));
            }
            Console.WriteLine();
        } 

        public static void PrintInfo(IEnumerable<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(FirstName + " " + LastName);
            return sb.ToString();
        }
    }
}
