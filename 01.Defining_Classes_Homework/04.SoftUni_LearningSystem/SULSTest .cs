namespace _03.SoftUni_LearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class SulsTest
    {
        public static void ExtractCurrentStudents(List<object> listObj)
        {
            var currentStudents = listObj.Select(st => st as CurrentStudent)
                .Where(st => st is CurrentStudent);

            var sortedStudents = currentStudents.OrderBy(st => st.AverageGrade);

            int line = 1;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("\n{7}_{0}_\nName: {1} {2}\nAge: {3}\nStudent number: {4}\nField: {5}\nScore: {6}", line, student.FirstName, student.LastName, student.Age, student.StudentNumber, student.Field, student.AverageGrade, student.GetType().Name);
                line++;
            }
        }
    }
}
