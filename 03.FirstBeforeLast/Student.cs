namespace FirstBeforeLast
{
    using System;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(FirstName + " " + LastName + " " + Age);
            return sb.ToString();
        }
    }
}
