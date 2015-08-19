namespace _18.GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string name;
        private string groupName;

        public Student(string name, string groupName)
        {
            this.Name = name;
            this.GroupName = groupName;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is required here!");
                }
                this.name = value;
            }
        }

        public string GroupName
        {
            get { return this.groupName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Group name is required!");
                }
                this.groupName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} is in {1}", this.Name, this.GroupName);
        }
    }
}
