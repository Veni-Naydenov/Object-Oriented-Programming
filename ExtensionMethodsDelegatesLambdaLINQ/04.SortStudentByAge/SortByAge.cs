//4.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
using System;
using System.Linq;

namespace _04.SortStudentByAge
{
    class Student
    {
        private string firstName;
        private string lastName;
        private byte age;

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

        public byte Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
    }
    class SortByAge
    {
        private static void SelectStudents(Student[] students)
        {
            var selected =
                from Student stud in students
                where stud.Age > 17 && stud.Age<25
                select stud;

            Console.WriteLine("\nSelected students with age between 18 and 24:");
            int index = 1;
            foreach (var name in selected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}:", index++);
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        static void Main()
        {
            Student[] students = new Student[6];
            string[] firstNames = { "Pesho", "Ivan", "Kosta", "Iva", "Kocho", "Aa" };
            string[] lastNames = { "Kocev", "Kolev", "Tsonev", "Zorova", "Mocho", "Bb" };
            byte[] age = { 11, 19, 23, 18, 21, 24 };

            for (int i = 0; i < 6; i++)
            {
                students[i] = new Student();
                students[i].FirstName = firstNames[i];
                students[i].LastName = lastNames[i];
                students[i].Age = age[i];
            }

            int index = 1;
            Console.WriteLine("All available students: ");
            foreach (Student name in students)
            {
                Console.Write("{0}: ", index++);
                Console.WriteLine(name.FirstName + " " + name.LastName+", "+name.Age+" years old");
            }

            SelectStudents(students);
        }
    }
}
