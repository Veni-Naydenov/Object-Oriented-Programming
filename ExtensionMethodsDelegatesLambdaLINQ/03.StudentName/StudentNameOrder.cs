//3.Write a method that from a given array of students finds all students whose first name is before 
// its last name alphabetically. Use LINQ query operators.
using System;
using System.Linq;

namespace _03.StudentName
{
    class Student
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
    }

    class StudentNameOrder
    {
        private static void SelectStudents(Student[] students)
        {
            var selected =
                from Student stud in students
                where stud.LastName.CompareTo(stud.FirstName) > 0
                select stud;

            Console.WriteLine("\nThe selected students are:");
            int index = 1;
            foreach (var name in selected)
            {
                Console.Write("{0}:", index++);
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Student[] students = new Student[6];
            string[] firstNames = { "Pesho", "Ivan", "Kosta", "Iva", "Kocho" ,"Aa"};
            string[] lastNames = { "Kocev", "Kolev", "Tsonev", "Zorova" ,"Mocho","Bb"};
           
            for (int i = 0; i < 6; i++)
            {
                students[i] = new Student();
                students[i].FirstName = firstNames[i];
                students[i].LastName = lastNames[i];
            }

            int index = 1;
            Console.WriteLine("All available students: ");
            foreach (Student name in students)
            {
                Console.Write("{0}:", index++);
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }

            SelectStudents(students);
        }
    }
}
