namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestOperationWithStudent
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", "Hristov", 22, 122, "02555633",
                "ivan@gmail.com", new List<int>() { 2, 3, 5, 6 }, 2);
            Student student2 = new Student("Anna", "Maria", 18, 223, "+359 2289366",
               "anna@gmail.com", new List<int>() { 6, 5, 2, 3 }, 2);
            Student student3 = new Student("Peshanka", "Jordanova", 55, 456, "888289896",
               "peshka@abv.bg", new List<int>() { 4, 4, 5, 3 }, 7);
            Student student4 = new Student("Fozi", "Djungerov", 25, 789, "+3592 888289825",
                "fozi@abv.bg", new List<int>() { 4, 5, 6, 6 }, 2);
            Student student5 = new Student("Fozi", "Ananiev", 25, 789, "888289825",
                "foziAnan@abv.bg", new List<int>() { 2, 2, 2, 6 }, 3);

            var studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            studentList.Add(student5);

            var group2Students = studentList.Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);
            int line = 1;

            PrintStudents(line, group2Students);
            line = 1;
            //Problem 5.	Students by First and Last Name

            Console.WriteLine("\tStudents by First and Last Name\n");

            var studentsByName = studentList.Where(st => st.FirstName.CompareTo(st.LastName) == -1);

            PrintStudents(line, studentsByName);
            line = 1;
            //Problem 6.	Students by Age
            Console.WriteLine("\tStudents by Age\n");

            var ageGrouped = studentList.Where(st => (st.Age > 17 && st.Age < 25));

            foreach (var student in ageGrouped)
            {
                Console.WriteLine("##### Result {0} --{1}", line, new string('#', 50));
                Console.WriteLine("Firs tName{0}\nLast Name: {1}\nAge: {2}",
                student.FirstName, student.LastName, student.Age);
                line++;
            }
            line = 1;
            //Problem 7.	Sort Students
            Console.WriteLine("\tSort Students\n");

            var sortedByNamesDesc = studentList.OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);

            PrintStudents(line, sortedByNamesDesc);
            line = 1;
            //Problem 8.	Filter Students by Email Domain
            Console.WriteLine("\tFilter Students by Email Domain\n");

            var byEmail = studentList.Where(st => st.Email.Contains("@abv.bg"));
            PrintStudents(line, byEmail);
            line = 1;
            //Problem 9.	Filter Students by Phone
            Console.WriteLine("\tFilter Students by Phone\n");

            var startWith = new string[] { "02", "+3592", "+359 2" };

            IEnumerable<Student> byPhone;
            foreach (var startNum in startWith)
            {
                byPhone = studentList.Where(st => st.PhoneNumber.StartsWith(startNum));
                PrintStudents(line, byPhone);
            }

            //Problem 10.	Excellent Students
            Console.WriteLine("\tExcellent Students\n");

            var exelentStudents = studentList.Where(st => st.AllMarks.ToString().Contains("6"));
            //PrintStudents(line,exelentStudents);
            var anonmos = new Student[exelentStudents.Count()];

            foreach (var item in exelentStudents)
            {
                var anonimus = new { FullName = item.FirstName + " " + item.LastName, Marks = item.AllMarks };
                Console.WriteLine("Full Name: {0}\nMarks: {1}", anonimus.FullName, anonimus.Marks);
            }
        }

        private static int PrintStudents(int line, IEnumerable<Student> byEmail)
        {
            foreach (var student in byEmail)
            {
                Console.WriteLine("##### Result {0} --{1}", line, new string('#', 50));
                Console.WriteLine(student.ToString());
                line++;
            }
            return line;
        }
    }
}
