namespace _03.SoftUni_LearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Trainer : Person, ITrainer
    {
        private static IEnumerable<string> courses = new List<string>();
        private IEnumerable<string> selfCourses = new List<string>();

        public Trainer(string firstName, string lastName, uint age)
            : base(firstName, lastName, age)
        {

        }

        public IEnumerable<string> SelfCourses
        {
            get
            {
                return this.selfCourses;
            }
            set
            {
                this.selfCourses = value;
            }
        }

        public static IEnumerable<string> Courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = value;
            }
        }

        public void CreateCourse(string courseName)
        {
            ((List<string>)(courses)).Add(courseName);
            AddToCourses(courseName);

            Console.WriteLine("{0}: {1} {2} {3}", GetType().Name.ToString(), this.FirstName, this.LastName, this.Age);
            Console.WriteLine("Course: {0}, Successfully created\n", courseName);
        }

        public void AddToCourses(string courseName)
        {
            ((List<string>)(this.selfCourses)).Add(courseName);
        }
    }
}
