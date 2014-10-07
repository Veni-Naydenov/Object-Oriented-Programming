namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Class : People
    {
        IList<Teacher> teachers;

        public Class(string name, IList<Teacher> teachers, string details = null)
        {
            base.Name = name;
            this.Teachers = teachers;
            base.Details = details;
        }

        public IList<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public override string ToString()
        {
            var allTeachers = new StringBuilder();
            var allTeachersNames = new StringBuilder();
            foreach (var teacher in this.teachers)
            {
                allTeachersNames.AppendFormat("{0}/ ", teacher.Name);
                allTeachers.AppendFormat("{0}", teacher.ToString());
            }

            string classInfo = string.Format(
                "Class name: {0}\nClass details: {1}\nClass Teachers: {2}\n{3}",
                this.Name,
                this.Details,
                allTeachersNames,
                allTeachers);

            return classInfo;
        }
    }
}
