namespace _03.SoftUni_LearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SeniorTrainer : Trainer, IDeletableCourse
    {
        public SeniorTrainer(string firstName, string lastName, uint age)
            : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string courseName)
        {
            if (!Courses.Contains(courseName))
            {
                throw new ArgumentException("The course do NOT exist");
            }

            ((List<string>)(Courses)).Remove(courseName);
            DeleteSelfCourse(courseName);

            Console.WriteLine("DELETED /{0}/ Successfully by {1}: {2} {3}", courseName, GetType().Name.ToString(), this.FirstName, this.LastName);
        }

        public void DeleteSelfCourse(string courseName)
        {
            ((List<string>)(this.SelfCourses)).Remove(courseName);
        }
    }
}
