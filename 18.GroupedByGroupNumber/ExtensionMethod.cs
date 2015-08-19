namespace _18.GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionMethod
    {
        public static List<string> GroupByGroupName(this IEnumerable<Student> students)
        {
            var groupByGroupName = students
                .GroupBy(st => st.GroupName);

            List<string> result = new List<string>();

            foreach (var group in groupByGroupName)
            {
                var current = new List<string>();

                foreach (var value in group)
                {
                    current.Add(value.Name);
                }

                result.Add(group.Key + " - " + string.Join(", ", current));
            }

            return result;
        }
    }
}
