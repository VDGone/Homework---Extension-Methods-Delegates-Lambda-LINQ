namespace _18.GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentTest
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student ("Ivan", "Biology"),
                new Student ("Iglika", "Biology"),
                new Student ("Minka", "Math"),
                new Student ("Mariq", "Chemestry"),
                new Student ("Angel", "Math")
            };
            Console.WriteLine("Sorted with Linq method:");
            var sortByGroup = students
                .GroupBy(st => st.GroupName);

            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var group in sortByGroup)
            {
                var current = new List<string>();
                foreach (var value in group)
                {
                    current.Add(value.Name);
                }

                result.Add(group.Key, string.Join(", ", current));
            }

            foreach (var pair in result)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }

            Console.WriteLine("\n\rSort with extension method:");
            var withExtensionGrouped = students.GroupByGroupName();

            foreach (var group in withExtensionGrouped)
            {
                Console.WriteLine(group);
            }
        }
    }
}
