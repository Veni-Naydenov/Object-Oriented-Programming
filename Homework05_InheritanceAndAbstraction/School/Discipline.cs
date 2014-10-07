namespace School
{
    using System;
    using System.Collections.Generic;

    public class Discipline : People
    {
        private ushort countOfLectures = 0;
        private IList<Student> students;

        public Discipline(string name,
            ushort lecturesCount,
            IList<Student> students,
            string details = null)
        {
            base.Name = name;
            this.CountOfLectures = lecturesCount;
            this.Students = students;
            base.Details = details;

        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public ushort CountOfLectures
        {
            get
            {
                return this.countOfLectures;
            }
            set
            {
                this.countOfLectures = value;
            }
        }
    }
}
